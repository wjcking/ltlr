#pragma once
#include "Biological.h"
#include <vector>
#include <string>
#include <unordered_map>

class Chemcial : public Biological
{
protected:

public:
	Chemcial();
	~Chemcial();
	virtual  Asnical& Generate(const Dynamic&) override;
	virtual  Asnical& Rotate(const Dynamic&) override;
	virtual  Asnical& Penetrate(const Dynamic&) override;
	virtual  Asnical& Entertain(const Dynamic&) override;
	virtual  Asnical& GetComplexity(const Dynamic&) override;
};