using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001A1 RID: 417
	public sealed class LockHolder : ValueType
	{
		// Token: 0x06001B1B RID: 6939 RVA: 0x000A407C File Offset: 0x000A227C
		// Note: this type is marked as 'beforefieldinit'.
		static LockHolder()
		{
			Il2CppClassPointerStore<LockHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "LockHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LockHolder>.NativeClassPtr);
			LockHolder.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockHolder>.NativeClassPtr, "_lock");
			LockHolder.NativeMethodInfoPtr_Hold_Public_Static_LockHolder_Lock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockHolder>.NativeClassPtr, 100667979);
			LockHolder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockHolder>.NativeClassPtr, 100667980);
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x000A40E8 File Offset: 0x000A22E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353013, XrefRangeEnd = 1353015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LockHolder Hold(Lock l)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockHolder.NativeMethodInfoPtr_Hold_Public_Static_LockHolder_Lock_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LockHolder(intPtr);
			}
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x000A4124 File Offset: 0x000A2324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353015, XrefRangeEnd = 1353017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockHolder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x00008B3E File Offset: 0x00006D3E
		public LockHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00008B47 File Offset: 0x00006D47
		public LockHolder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockHolder>.NativeClassPtr))
		{
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x000A415C File Offset: 0x000A235C
		// (set) Token: 0x06001B21 RID: 6945 RVA: 0x00008B59 File Offset: 0x00006D59
		public unsafe Lock _lock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockHolder.NativeFieldInfoPtr__lock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockHolder.NativeFieldInfoPtr__lock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018DC RID: 6364
		private static readonly IntPtr NativeFieldInfoPtr__lock;

		// Token: 0x040018DD RID: 6365
		private static readonly IntPtr NativeMethodInfoPtr_Hold_Public_Static_LockHolder_Lock_0;

		// Token: 0x040018DE RID: 6366
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
