#include <stdio.h>
#include "buffer.h"




void initBuffer(void);

int readBufferValueAsUint8(uint32_t index, uint8_t* value);
int writeBufferValueAsUint8(uint32_t index, uint8_t value);

int readBufferValueAsUint32(uint32_t index, uint32_t* value);
int writeBufferValueAsUint32(uint32_t index, uint32_t value);
uint8_t* findBufferValueAsUint8(uint8_t value);
uint32_t* findBufferValueAsUint32(uint32_t value);

int main()
{
	initBuffer();

	uint8_t value = 0;
	for(int index = 0; index < BUFFER_SIZE; index++)
	{
		printf("Buffer write: index[%d] <- %d\n", index, value);
		writeBufferValueAsUint8(index, value);
		value += 10;
	}

	for(int index = 0; index < BUFFER_SIZE; index++)
	{
		readBufferValueAsUint8(index, &value);
		printf("Buffer read: index[%d] -> %d\n", index, value);
	}

	return (0);
}
