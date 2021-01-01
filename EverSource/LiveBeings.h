#pragma once
#include "Atmosphere.h"
#include "LiveInfo.h"

class Creatures : public Atmosphere
{
protected:
	string name;
public:
	Creatures() {};
	~Creatures() {};
};

class Memory : public Atmosphere
{

protected:
	int id;
	//vecter3d(x,y,z) ats cup gaps
	double distance;
	double volume;
	int type;
	//点对点、链表
	Memory* memory;
public:
	inline double& getVolume() { return volume; };
	inline int& getType() { return type; };
	//姐 老婆 Aidness fel salpura atlantis 
	//inline MemoryFunc* setFunc(MemoryFunc* func) { this->func = func; }
	//inline MemoryFunc* getFunc() { return func; }
};

//Molecule 
class Cells : public Creatures
{
protected:
	Memory* memory = nullptr;
public:
	Cells() {};
	~Cells()
	{
		if (memory != nullptr)
			delete memory;
	};
};

class LiveBeing :public Cells
{
public:
	LiveBeing() {};
	~LiveBeing() {};
	void arouse();
	void revive();
};

class Human :public LiveBeing
{
private:
	bool isPossessed = false;
	//点对点
	RetrieveInfo retrieve;
public:
	Human() {};
	~Human() {};
};


class Animals :public LiveBeing
{
protected:
public:
	Animals() {};
	~Animals() {};
};


class Plants :public Cells
{
public:
	Plants() {};
	~Plants() {};
};