//#include "stdafx.h"
#include "Biological.h"


Biological::Biological()
{
}


Biological::~Biological()
{
}

//Biological
Asnical & Biological::Generate(const Dynamic & para)
{
	Physical::Generate(para);
	cout << "	[Biological]Generating" << endl;
	return outcome;
}

Asnical & Biological::Rotate(const Dynamic & para)
{
	Physical::Rotate(para);
	cout << "	[Biological]Rotating" << endl;
	return outcome;
}

Asnical & Biological::Penetrate(const Dynamic & para)
{
	Physical::Penetrate(para);
	cout << "	[Biological]Penetrating" << endl;
	return outcome;
}

Asnical & Biological::Entertain(const Dynamic & para)
{
	Physical::Entertain(para);
	cout << "	[Biological]Entertaining" << endl;
	return outcome;
}

Asnical & Biological::GetComplexity(const Dynamic & para)
{
	Physical::GetComplexity(para);
	cout << "	[Biological]Getting" << endl;
	return outcome;
}