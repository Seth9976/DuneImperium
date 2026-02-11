using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x0200009B RID: 155
	public class TraceSwitch : Switch
	{
		// Token: 0x06000B38 RID: 2872 RVA: 0x00005E9B File Offset: 0x0000409B
		// Note: this type is marked as 'beforefieldinit'.
		static TraceSwitch()
		{
			Il2CppClassPointerStore<TraceSwitch>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "TraceSwitch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraceSwitch>.NativeClassPtr);
			TraceSwitch.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TraceSwitch>.NativeClassPtr, 100664971);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00046BB4 File Offset: 0x00044DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451121, XrefRangeEnd = 451127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraceSwitch(string displayName, string description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TraceSwitch>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TraceSwitch.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00005ED4 File Offset: 0x000040D4
		public TraceSwitch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
