using System;

namespace Microsoft.Win32.Security
{
	[Flags]
	public enum AccessType : uint
	{
		DELETE = 0x10000u,
		READ_CONTROL = 0x20000u,
		WRITE_DAC = 0x40000u,
		WRITE_OWNER = 0x80000u,
		SYNCHRONIZE = 0x100000u,
		STANDARD_RIGHTS_REQUIRED = 0xF0000u,
		STANDARD_RIGHTS_READ = 0x20000u,
		STANDARD_RIGHTS_WRITE = 0x20000u,
		STANDARD_RIGHTS_EXECUTE = 0x20000u,
		STANDARD_RIGHTS_ALL = 0x1F0000u,
		SPECIFIC_RIGHTS_ALL = 0xFFFFu,
		ACCESS_SYSTEM_SECURITY = 0x1000000u,
		MAXIMUM_ALLOWED = 0x2000000u,
		GENERIC_READ = 0x80000000u,
		GENERIC_WRITE = 0x40000000u,
		GENERIC_EXECUTE = 0x20000000u,
		GENERIC_ALL = 0x10000000u
	}
}
