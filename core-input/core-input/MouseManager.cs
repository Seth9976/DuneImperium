using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000008 RID: 8
public static class MouseManager : Object
{
	// Token: 0x06000027 RID: 39 RVA: 0x00007938 File Offset: 0x00005B38
	// Note: this type is marked as 'beforefieldinit'.
	static MouseManager()
	{
		Il2CppClassPointerStore<MouseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "", "MouseManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseManager>.NativeClassPtr);
		MouseManager.NativeMethodInfoPtr_IsMacControlHeld_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseManager>.NativeClassPtr, 100663311);
		MouseManager.NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseManager>.NativeClassPtr, 100663312);
		MouseManager.NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseManager>.NativeClassPtr, 100663313);
		MouseManager.NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseManager>.NativeClassPtr, 100663314);
		MouseManager.NativeMethodInfoPtr_getMouseButton_Private_Static_Boolean_MouseButton_ButtonRequestType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseManager>.NativeClassPtr, 100663315);
		MouseManager.NativeMethodInfoPtr_getMouseButtonFromQuery_Private_Static_Boolean_MouseButton_ButtonRequestType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseManager>.NativeClassPtr, 100663316);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000079E0 File Offset: 0x00005BE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118987, XrefRangeEnd = 1118994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMacControlHeld()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseManager.NativeMethodInfoPtr_IsMacControlHeld_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00007A10 File Offset: 0x00005C10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1118994, XrefRangeEnd = 1119006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetMouseButton(MouseButton button)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref button;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseManager.NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_MouseButton_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00007A50 File Offset: 0x00005C50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119006, XrefRangeEnd = 1119018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetMouseButtonDown(MouseButton button)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref button;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseManager.NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_MouseButton_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00007A90 File Offset: 0x00005C90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119018, XrefRangeEnd = 1119030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetMouseButtonUp(MouseButton button)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref button;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseManager.NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_MouseButton_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00007AD0 File Offset: 0x00005CD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119030, XrefRangeEnd = 1119042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool getMouseButton(MouseButton button, MouseManager.ButtonRequestType mouseQuery)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref button;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mouseQuery;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseManager.NativeMethodInfoPtr_getMouseButton_Private_Static_Boolean_MouseButton_ButtonRequestType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00007B1C File Offset: 0x00005D1C
	[CallerCount(0)]
	public unsafe static bool getMouseButtonFromQuery(MouseButton button, MouseManager.ButtonRequestType mouseQuery)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref button;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mouseQuery;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseManager.NativeMethodInfoPtr_getMouseButtonFromQuery_Private_Static_Boolean_MouseButton_ButtonRequestType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600002E RID: 46 RVA: 0x0000216D File Offset: 0x0000036D
	public MouseManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeMethodInfoPtr_IsMacControlHeld_Public_Static_Boolean_0;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeMethodInfoPtr_GetMouseButton_Public_Static_Boolean_MouseButton_0;

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonDown_Public_Static_Boolean_MouseButton_0;

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeMethodInfoPtr_GetMouseButtonUp_Public_Static_Boolean_MouseButton_0;

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeMethodInfoPtr_getMouseButton_Private_Static_Boolean_MouseButton_ButtonRequestType_0;

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeMethodInfoPtr_getMouseButtonFromQuery_Private_Static_Boolean_MouseButton_ButtonRequestType_0;

	// Token: 0x020000B1 RID: 177
	public enum ButtonRequestType
	{
		// Token: 0x040004E6 RID: 1254
		Current,
		// Token: 0x040004E7 RID: 1255
		Up,
		// Token: 0x040004E8 RID: 1256
		Down
	}
}
