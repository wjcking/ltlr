#pragma once
#include "Chemcial.h"
class Atmosphere : public Chemcial
{
protected:
	SphereInfo sphereInfo;
public:
	Atmosphere();
	~Atmosphere();
	inline static Asnical GetInstance(const SphereInfo& param)
	{
		Asnical outcome;
		if (param.isOutSpace)
		{
			//outcome.name = "Mars";
			outcome.gravitySphere = GravitySphere::centralCore;
		}
		else
		{
			//outcome.name = "earth";
			outcome.gravitySphere = GravitySphere::air;
		}	
		cout << "[Atmosphere]";
		cout <<"is out space:"<< boolalpha << param.isOutSpace;
		//cout << " name:"  << outcome.name.c_str();
		cout << " gravity sphere:"  << static_cast<unsigned short>( outcome.gravitySphere) << endl;
		return outcome;
		 
	};
};

