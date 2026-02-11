using System;

namespace InControl
{
	// Token: 0x02000036 RID: 54
	public enum InputDeviceDriverType : ushort
	{
		// Token: 0x0400050F RID: 1295
		Unknown,
		// Token: 0x04000510 RID: 1296
		HID,
		// Token: 0x04000511 RID: 1297
		USB,
		// Token: 0x04000512 RID: 1298
		Bluetooth,
		// Token: 0x04000513 RID: 1299
		XInput,
		// Token: 0x04000514 RID: 1300
		DirectInput,
		// Token: 0x04000515 RID: 1301
		RawInput,
		// Token: 0x04000516 RID: 1302
		AppleGameController,
		// Token: 0x04000517 RID: 1303
		SDLJoystick,
		// Token: 0x04000518 RID: 1304
		SDLController
	}
}
