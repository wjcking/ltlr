//#include "stdafx.h"
#include "Physical.h"


Physical::Physical()
{
}


Physical::~Physical()
{
}

Asnical & Physical::Generate(const Dynamic & para)
{
	Energy::Generate(para);
	cout << "	[Physical]Generating" << endl;
	return outcome;
}

Asnical & Physical::Rotate(const Dynamic & para)
{
	Energy::Rotate(para);
	cout << "	[Physical]Rotating" << endl;
	return outcome;
}

Asnical & Physical::Penetrate(const Dynamic & para)
{
	Energy::Penetrate(para);
	cout << "	[Physical]Penetrating" << endl;
	return outcome;
}

Asnical & Physical::Entertain(const Dynamic & para)
{
	Energy::Entertain(para);
	cout << "	[Physical]Entertaining" << endl;
	return outcome;
}

Asnical & Physical::GetComplexity(const Dynamic & para)
{
	Energy::GetComplexity(para);
	cout << "	[Physical]Getting" << endl;
	return outcome;
}