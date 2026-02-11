using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x0200008E RID: 142
	public class BooleanSwitch : Switch
	{
		// Token: 0x06000AAE RID: 2734 RVA: 0x00005B9D File Offset: 0x00003D9D
		// Note: this type is marked as 'beforefieldinit'.
		static BooleanSwitch()
		{
			Il2CppClassPointerStore<BooleanSwitch>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "BooleanSwitch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BooleanSwitch>.NativeClassPtr);
			BooleanSwitch.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanSwitch>.NativeClassPtr, 100664903);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00044D10 File Offset: 0x00042F10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442644, RefRangeEnd = 442645, XrefRangeStart = 442638, XrefRangeEnd = 442644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BooleanSwitch(string displayName, string description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BooleanSwitch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BooleanSwitch.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00005BD6 File Offset: 0x00003DD6
		public BooleanSwitch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
