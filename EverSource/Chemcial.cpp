//#include "stdafx.h"
#include "Chemcial.h"


Chemcial::Chemcial()
{
}


Chemcial::~Chemcial()
{
}

//Chemcial
Asnical & Chemcial::Generate(const Dynamic & para)
{
	Biological::Generate(para);
	cout << "	[Chemcial]Generating" << endl;


	return outcome;
}

Asnical & Chemcial::Rotate(const Dynamic & para)
{
	Biological::Rotate(para);
	cout << "	[Chemcial]Rotating" << endl;
	return outcome;
}

Asnical & Chemcial::Penetrate(const Dynamic & para)
{
	Biological::Penetrate(para);
	cout << "	[Chemcial]Penetrating" << endl;
	return outcome;
}

Asnical & Chemcial::Entertain(const Dynamic & para)
{
	Biological::Entertain(para);
	cout << "	[Chemcial]Entertaining" << endl;
	return outcome;
}

Asnical & Chemcial::GetComplexity(const Dynamic & para)
{
	Biological::GetComplexity(para);
	cout << "	[Chemcial]Getting" << endl;
	return outcome;
}