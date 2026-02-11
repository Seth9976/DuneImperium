using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.IO
{
	// Token: 0x02000183 RID: 387
	public class IODescriptionAttribute : DescriptionAttribute
	{
		// Token: 0x060017B0 RID: 6064 RVA: 0x000788C0 File Offset: 0x00076AC0
		// Note: this type is marked as 'beforefieldinit'.
		static IODescriptionAttribute()
		{
			Il2CppClassPointerStore<IODescriptionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "IODescriptionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IODescriptionAttribute>.NativeClassPtr);
			IODescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IODescriptionAttribute>.NativeClassPtr, 100667021);
			IODescriptionAttribute.NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IODescriptionAttribute>.NativeClassPtr, 100667022);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00078918 File Offset: 0x00076B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470031, XrefRangeEnd = 470035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IODescriptionAttribute(string description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IODescriptionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(description);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IODescriptionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x00078964 File Offset: 0x00076B64
		public unsafe override string Description
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IODescriptionAttribute.NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0000A4AE File Offset: 0x000086AE
		public IODescriptionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_Virtual_get_String_0;
	}
}
