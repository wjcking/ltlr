#pragma once
#include <iostream>

using namespace std;

enum class GravitySphere
{
	air = 0,
	centralCore = 1,
	atmosphere =2,
};
/*
*Asniyake 标量 下的子标量
*/
struct Asnical
{
	string result;
	GravitySphere gravitySphere = GravitySphere::air;
};

struct SphereInfo : Asnical
{
	long snic;
	bool isOutSpace = false;
	//int pipeline; 
	//[chronosphere as a boundary]传送中挑刺
	//chronosnic 地球不知道 
	//以(人|美)本|准 目前过渡人比较多 SelfGet
	//anti- altair - fusion
};

//参数
struct Dynamic
{
	string name;
};
