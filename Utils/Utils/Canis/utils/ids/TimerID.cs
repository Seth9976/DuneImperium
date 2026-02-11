using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.utils.ids
{
	// Token: 0x02000021 RID: 33
	public sealed class TimerID : TypedID
	{
		// Token: 0x06000148 RID: 328 RVA: 0x0000989C File Offset: 0x00007A9C
		// Note: this type is marked as 'beforefieldinit'.
		static TimerID()
		{
			Il2CppClassPointerStore<TimerID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.ids", "TimerID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerID>.NativeClassPtr);
			TimerID.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerID>.NativeClassPtr, 100663504);
			TimerID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerID>.NativeClassPtr, 100663505);
			TimerID.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerID>.NativeClassPtr, 100663506);
			TimerID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerID>.NativeClassPtr, 100663507);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000991C File Offset: 0x00007B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180029, XrefRangeEnd = 1180034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerID.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00009968 File Offset: 0x00007B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180034, XrefRangeEnd = 1180038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerID.NativeMethodInfoPtr__ctor_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000099B0 File Offset: 0x00007BB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1180043, RefRangeEnd = 1180045, XrefRangeStart = 1180038, XrefRangeEnd = 1180043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerID()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerID>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerID.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000099EC File Offset: 0x00007BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180045, XrefRangeEnd = 1180053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedID CreateID(string guid)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerID.NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypedID>(intPtr3) : null;
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000025CB File Offset: 0x000007CB
		public TimerID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_CreateID_Public_Static_TypedID_String_0;
	}
}
