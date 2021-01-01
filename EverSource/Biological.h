#pragma once
#include "Physical.h"

class Biological : public Physical
{
public:
	Biological();
	~Biological() ;
	virtual  Asnical& Generate(const Dynamic&) override;
	virtual  Asnical& Rotate(const Dynamic&) override;
	virtual  Asnical& Penetrate(const Dynamic&) override;
	virtual  Asnical& Entertain(const Dynamic&) override;
	virtual  Asnical& GetComplexity(const Dynamic&) override;
};