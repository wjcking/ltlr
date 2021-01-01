#pragma once
#include "Energy.h"
class Physical : public Energy
{
public:
	Physical();
	~Physical();
	virtual  Asnical& Generate(const Dynamic&) override;
	virtual  Asnical& Rotate(const Dynamic&) override;
	virtual  Asnical& Penetrate(const Dynamic&) override;
	virtual  Asnical& Entertain(const Dynamic&) override;
	virtual  Asnical& GetComplexity(const Dynamic&) override;
};