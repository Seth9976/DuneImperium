using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000475 RID: 1141
	[StructLayout(2)]
	public struct DaylightTimeStruct
	{
		// Token: 0x0600450D RID: 17677 RVA: 0x00144494 File Offset: 0x00142694
		// Note: this type is marked as 'beforefieldinit'.
		static DaylightTimeStruct()
		{
			Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "DaylightTimeStruct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr);
			DaylightTimeStruct.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr, "Start");
			DaylightTimeStruct.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr, "End");
			DaylightTimeStruct.NativeFieldInfoPtr_Delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr, "Delta");
			DaylightTimeStruct.NativeMethodInfoPtr__ctor_Public_Void_DateTime_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr, 100673458);
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00144514 File Offset: 0x00142714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 636842, RefRangeEnd = 636843, XrefRangeStart = 636842, XrefRangeEnd = 636843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaylightTimeStruct(DateTime start, DateTime end, TimeSpan delta)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaylightTimeStruct.NativeMethodInfoPtr__ctor_Public_Void_DateTime_DateTime_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x000190E6 File Offset: 0x000172E6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DaylightTimeStruct>.NativeClassPtr, ref this));
		}

		// Token: 0x040038F5 RID: 14581
		private static readonly IntPtr NativeFieldInfoPtr_Start;

		// Token: 0x040038F6 RID: 14582
		private static readonly IntPtr NativeFieldInfoPtr_End;

		// Token: 0x040038F7 RID: 14583
		private static readonly IntPtr NativeFieldInfoPtr_Delta;

		// Token: 0x040038F8 RID: 14584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_DateTime_TimeSpan_0;

		// Token: 0x040038F9 RID: 14585
		[FieldOffset(0)]
		public readonly DateTime Start;

		// Token: 0x040038FA RID: 14586
		[FieldOffset(8)]
		public readonly DateTime End;

		// Token: 0x040038FB RID: 14587
		[FieldOffset(16)]
		public readonly TimeSpan Delta;
	}
}
