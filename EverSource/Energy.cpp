//#include "stdafx.h"
#include "Energy.h"


Energy::Energy()
{
}


Energy::~Energy()
{
}

Asnical & Energy::Generate(const Dynamic & para)
{
	Crystal::Generate(para);
	cout << "	[Energy]Generating" << endl;
	return outcome;
}

Asnical & Energy::Rotate(const Dynamic & para)
{
	Crystal::Rotate(para);
	cout << "	[Energy]Rotating" << endl;
	return outcome;
}

Asnical & Energy::Penetrate(const Dynamic & para)
{
	Crystal::Penetrate(para);
	cout << "	[Energy]Penetrating" << endl;
	return outcome;
}

Asnical & Energy::Entertain(const Dynamic & para)
{
	Crystal::Entertain(para);
	cout << "	[Energy]Entertaining" << endl;
	return outcome;
}

Asnical & Energy::GetComplexity(const Dynamic & para)
{
	Crystal::GetComplexity(para);
	cout << "	[Energy]Getting" << endl;
	return outcome;
}