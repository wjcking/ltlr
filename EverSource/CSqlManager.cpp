#include "CSqlManager.h"

//二子修改return
_RecordsetPtr  SQLServer::executeRecordSet(_bstr_t commandText, VARIANT * recordsAffected, long options)
{
	::CoInitialize(nullptr);
	_ConnectionPtr  connection;
	_RecordsetPtr   recordSet;
	try
	{
		connection.CreateInstance(__uuidof(Connection));
		recordSet.CreateInstance(__uuidof(Recordset));
		assert(nullptr != connection);
		assert(nullptr != recordSet);
		if (nullptr == recordSet
			|| nullptr == connection)
			cout << "创建实例失败" << endl;

		connection->CommandTimeout = 25;
		connection->ConnectionString = "Provider=SQLOLEDB;Server=(local);Database=EverSource;User ID=sa;integrated security=SSPI";

		connection->Open("", "", "", adConnectUnspecified);
		assert(connection->GetState() == adStateOpen);
		if (connection->GetState() != adStateOpen)
			cout << "连接失败" << endl;

		recordSet = connection->Execute(commandText, recordsAffected, options);

	}
	catch (_com_error& e)
	{
		cout << e.Description() << endl;
	}

	::CoUninitialize();

	return recordSet;
}

vector<Interweave> SQLServer::getInterweavedList()
{
	auto recordSet = executeRecordSet("SELECT * FROM [EverSource].[dbo].[$interweaved]");
	vector<Interweave> list;

	while (!recordSet->adoEOF)
	{
		Interweave interweave;
		interweave.setID((int)recordSet->Fields->GetItem("id")->GetValue());
		interweave.setDimensionID((int)recordSet->Fields->GetItem("dimension_id")->GetValue());
		interweave.setInterClassified((int)recordSet->Fields->GetItem("inter_classified")->GetValue());
		interweave.setPhysicalID((int)recordSet->Fields->GetItem("physical_id")->GetValue());
		interweave.setDimensionID((int)recordSet->Fields->GetItem("chemical_id")->GetValue());
		interweave.setDimensionName((const char *)_bstr_t(recordSet->Fields->GetItem("dimension_name")->GetValue()));
		interweave.setInterweavedName((const char *)_bstr_t(recordSet->Fields->GetItem("interweaved_name")->GetValue()));
		interweave.setPhysicalName((const char *)_bstr_t(recordSet->Fields->GetItem("physical_name")->GetValue()));
		interweave.setChemicalName((const char *)_bstr_t(recordSet->Fields->GetItem("chemical_name")->GetValue()));
		interweave.setAbbr((const char *)_bstr_t(recordSet->Fields->GetItem("abbr")->GetValue()));
		interweave.setName((const char *)_bstr_t(recordSet->Fields->GetItem("name")->GetValue()));
		interweave.setDesc((const char *)_bstr_t(recordSet->Fields->GetItem("desc")->GetValue()));/**/
	 
		list.push_back(interweave);
		recordSet->MoveNext();//下一条记录	

		
		interweave.getString();
	}
	recordSet->Close();


	return list;
}
