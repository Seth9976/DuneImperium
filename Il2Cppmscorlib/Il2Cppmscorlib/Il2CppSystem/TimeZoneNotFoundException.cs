using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000F1 RID: 241
	[Serializable]
	public class TimeZoneNotFoundException : Exception
	{
		// Token: 0x06000F97 RID: 3991 RVA: 0x0006E3C4 File Offset: 0x0006C5C4
		// Note: this type is marked as 'beforefieldinit'.
		static TimeZoneNotFoundException()
		{
			Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeZoneNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr);
			TimeZoneNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr, 100666004);
			TimeZoneNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr, 100666005);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0006E41C File Offset: 0x0006C61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321533, XrefRangeEnd = 1321537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0006E458 File Offset: 0x0006C658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1321537, XrefRangeEnd = 1321541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeZoneNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeZoneNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeZoneNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00005C10 File Offset: 0x00003E10
		public TimeZoneNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CB5 RID: 3253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CB6 RID: 3254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
