//#include "stdafx.h"
#include "Crystal.h"
//#pragma comment(lib,"ODBC.lib")

//#include <odbc/Connection.h>
//#include <odbc/Environment.h>
//#include <odbc/Exception.h>
//#include <odbc/PreparedStatement.h>
//#include <odbc/ResultSet.h>


 
Crystal::Crystal()
{
}


Crystal::~Crystal()
{

}
Asnical & Crystal::Generate(const Dynamic &)
{
	
	return outcome;
}

Asnical & Crystal::Rotate(const Dynamic &)
{
	cout << "Rotating" << endl;
	return outcome;
}

Asnical & Crystal::Penetrate(const Dynamic &)
{
	cout << "Penetrating" << endl;
	return outcome;
}

Asnical & Crystal::Entertain(const Dynamic &)
{
	cout << "Entertaining" << endl;
	return outcome;
}
Asnical & Crystal::GetComplexity(const Dynamic &)
{

	cout << "Requesting:" << endl;
	return outcome;
}


