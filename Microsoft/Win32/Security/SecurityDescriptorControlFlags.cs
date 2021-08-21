using System;

namespace Microsoft.Win32.Security
{
	[Flags]
	public enum SecurityDescriptorControlFlags : ushort
	{
		SE_OWNER_DEFAULTED = 0x1,
		SE_GROUP_DEFAULTED = 0x2,
		SE_DACL_PRESENT = 0x4,
		SE_DACL_DEFAULTED = 0x8,
		SE_SACL_PRESENT = 0x10,
		SE_SACL_DEFAULTED = 0x20,
		SE_DACL_AUTO_INHERIT_REQ = 0x100,
		SE_SACL_AUTO_INHERIT_REQ = 0x200,
		SE_DACL_AUTO_INHERITED = 0x400,
		SE_SACL_AUTO_INHERITED = 0x800,
		SE_DACL_PROTECTED = 0x1000,
		SE_SACL_PROTECTED = 0x2000,
		SE_RM_CONTROL_VALID = 0x4000,
		SE_SELF_RELATIVE = 0x8000
	}
}