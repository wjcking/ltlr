#pragma once
#include <string>
#include <iostream>
using namespace std;
struct CellInfo
{
	int id;
	string name;
};
struct ColorInfo
{
	int id;
	string name;
	string hex;
	string desc;
	unsigned int r;
	unsigned int g;
	unsigned int b;

	ColorInfo() {};
	ColorInfo(const int& id, const string& name, const string& hex, const string& desc,
		const unsigned int& r,
		const unsigned int& g,
		const unsigned int& b) {};
};
//[郎咸平]那种元素不让别人知道
class Interweave
{
private:
	int id = 0;
	int dimension_id = 0;
	int interClassfied = 0;
	int physical_id = 0;
	string dimension_name;
	string interweaved_name;
	string physical_name;
	int classify = 0;
	string chemical_name;
	string abbr;
	string name ;
	string desc;
	int attribute = 0;
public:
	Interweave() {};
	inline int& 	 getID() { return  this->id; }
	inline int& 	 getDimensionID() { return  this->dimension_id; }
	inline int& 	 getInterClassified() { return  this->interClassfied; }
	inline int& 	 getPhysicalID() { return  this->physical_id; }
	inline string& 	 getDimensionName() { return  this->dimension_name; }
	inline string& 	 getInterweavedName() { return  this->interweaved_name; }
	inline string& 	 getPhysicalName() { return  this->physical_name; }
	inline int& 	 getClassify() { return  this->classify; }
	inline string& 	 getChemicalName() { return  this->chemical_name; }
	inline string& 	 getAbbr() { return  this->abbr; }
	inline string& 	 getName() { return  this->name; }
	inline string& 	 getDesc() { return  this->desc; }
	inline int& 	 getAttribute() { return  this->attribute; }

	inline int&    setID(const int& id) { return  this->id = id; };
	inline int&    setDimensionID(const int& dimension_id) { return this->dimension_id = dimension_id; };
	inline int&    setInterClassified(const int& interweaved_id) { return this->interClassfied = interweaved_id; };
	inline int&    setPhysicalID(const int& physical_id) { return this->physical_id = physical_id; };
	inline string& setDimensionName(const string&  dimension_name) { return this->dimension_name = dimension_name; };
	inline string& setInterweavedName(const string&  interweaved_name) { return this->interweaved_name = interweaved_name; };
	inline string& setPhysicalName(const string&  physical_name) { return this->physical_name = physical_name; };
	inline int&	   setClassify(const int& 	classify) { return this->classify = classify; };
	inline string& setChemicalName(const string&  chemical_name) { return this->chemical_name = chemical_name; };
	inline string& setAbbr(const string&  abbr) { return this->abbr = abbr; };
	inline string& setName(const string&  name) { return this->name = name; };
	inline string& setDesc(const string&  desc) { return this->desc = desc; };
	inline int&	   setAttribute(const int& attribute) { return this->attribute = attribute; };

	inline  void getString()
	{
		std::cout << id << "|";
		std::cout << dimension_name << "|";
		std::cout << interClassfied << "|";
		std::cout << chemical_name << "|";
		std::cout << abbr << "|";
		std::cout << name << "|";
		std::cout << desc << "|";
		std::cout << endl;
	}
};

