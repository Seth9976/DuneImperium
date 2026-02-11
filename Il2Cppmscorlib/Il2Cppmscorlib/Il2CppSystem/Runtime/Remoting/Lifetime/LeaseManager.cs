using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020002B5 RID: 693
	public class LeaseManager : Object
	{
		// Token: 0x06002C49 RID: 11337 RVA: 0x000E8998 File Offset: 0x000E6B98
		// Note: this type is marked as 'beforefieldinit'.
		static LeaseManager()
		{
			Il2CppClassPointerStore<LeaseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "LeaseManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr);
			LeaseManager.NativeFieldInfoPtr__objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, "_objects");
			LeaseManager.NativeFieldInfoPtr__timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, "_timer");
			LeaseManager.NativeMethodInfoPtr_SetPollTime_Public_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100670441);
			LeaseManager.NativeMethodInfoPtr_TrackLifetime_Public_Void_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100670442);
			LeaseManager.NativeMethodInfoPtr_StartManager_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100670443);
			LeaseManager.NativeMethodInfoPtr_StopManager_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100670444);
			LeaseManager.NativeMethodInfoPtr_ManageLeases_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100670445);
			LeaseManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100670446);
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x000E8A68 File Offset: 0x000E6C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1380239, RefRangeEnd = 1380240, XrefRangeStart = 1380234, XrefRangeEnd = 1380239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPollTime(TimeSpan timeSpan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeSpan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_SetPollTime_Public_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x000E8AA8 File Offset: 0x000E6CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1380266, RefRangeEnd = 1380267, XrefRangeStart = 1380240, XrefRangeEnd = 1380266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackLifetime(ServerIdentity identity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_TrackLifetime_Public_Void_ServerIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x000E8AEC File Offset: 0x000E6CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380267, XrefRangeEnd = 1380289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_StartManager_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x000E8B20 File Offset: 0x000E6D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380289, XrefRangeEnd = 1380291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_StopManager_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x000E8B54 File Offset: 0x000E6D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380291, XrefRangeEnd = 1380302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManageLeases(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_ManageLeases_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x000E8B98 File Offset: 0x000E6D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1380302, XrefRangeEnd = 1380308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaseManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x0000ED15 File Offset: 0x0000CF15
		public LeaseManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x000E8BD4 File Offset: 0x000E6DD4
		// (set) Token: 0x06002C52 RID: 11346 RVA: 0x0000ED1E File Offset: 0x0000CF1E
		public unsafe ArrayList _objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseManager.NativeFieldInfoPtr__objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseManager.NativeFieldInfoPtr__objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002C53 RID: 11347 RVA: 0x000E8C04 File Offset: 0x000E6E04
		// (set) Token: 0x06002C54 RID: 11348 RVA: 0x0000ED3D File Offset: 0x0000CF3D
		public unsafe Timer _timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseManager.NativeFieldInfoPtr__timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseManager.NativeFieldInfoPtr__timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400255B RID: 9563
		private static readonly IntPtr NativeFieldInfoPtr__objects;

		// Token: 0x0400255C RID: 9564
		private static readonly IntPtr NativeFieldInfoPtr__timer;

		// Token: 0x0400255D RID: 9565
		private static readonly IntPtr NativeMethodInfoPtr_SetPollTime_Public_Void_TimeSpan_0;

		// Token: 0x0400255E RID: 9566
		private static readonly IntPtr NativeMethodInfoPtr_TrackLifetime_Public_Void_ServerIdentity_0;

		// Token: 0x0400255F RID: 9567
		private static readonly IntPtr NativeMethodInfoPtr_StartManager_Public_Void_0;

		// Token: 0x04002560 RID: 9568
		private static readonly IntPtr NativeMethodInfoPtr_StopManager_Public_Void_0;

		// Token: 0x04002561 RID: 9569
		private static readonly IntPtr NativeMethodInfoPtr_ManageLeases_Public_Void_Object_0;

		// Token: 0x04002562 RID: 9570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
