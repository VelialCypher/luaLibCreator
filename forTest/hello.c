#include "lua.h"
#include "lauxlib.h"

int say_hello(lua_State *L) {
	printf("Hello from C module!");
	return 1;
}

static const struct luaL_Reg functions [] = {
	{"say_hello", say_hello},
	{NULL, NULL}
};

int luaopen_hello(lua_State *L) {
	luaL_register(L, "hello", functions);
	return 1;
}
