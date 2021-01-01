#pragma once
#include "Crystal.h"
class Energy : public Crystal
{
public:
	Energy();
	~Energy();
	virtual  Asnical& Generate(const Dynamic&) override;
	virtual  Asnical& Rotate(const Dynamic&) override;
	virtual  Asnical& Penetrate(const Dynamic&) override;
	virtual  Asnical& Entertain(const Dynamic&) override;
	virtual  Asnical& GetComplexity(const Dynamic&) override;
};

