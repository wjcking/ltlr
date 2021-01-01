#pragma once

#include <iostream>
#include <stdio.h>
#include <ICRSINT.H>
#include <string>
#include <vector>
#include "Interweave.h"
using namespace std;
#import "c:\\program files\\common files\\system\\ado\\msado15.dll"  no_namespace rename("EOF", "adoEOF")

class SQLServer
{
public:
	static _RecordsetPtr executeRecordSet(_bstr_t , VARIANT * = 0 , long =1);
	static vector<Interweave> getInterweavedList();
};