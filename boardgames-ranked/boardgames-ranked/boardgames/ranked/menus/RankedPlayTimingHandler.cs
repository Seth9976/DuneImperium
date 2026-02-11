using System;
using boardgames.menus.ui;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;

namespace boardgames.ranked.menus
{
	// Token: 0x02000029 RID: 41
	public class RankedPlayTimingHandler : VersionedView<RankedPlayProvider>
	{
		// Token: 0x06000171 RID: 369 RVA: 0x00007770 File Offset: 0x00005970
		// Note: this type is marked as 'beforefieldinit'.
		static RankedPlayTimingHandler()
		{
			Il2CppClassPointerStore<RankedPlayTimingHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedPlayTimingHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayTimingHandler>.NativeClassPtr);
			RankedPlayTimingHandler.NativeFieldInfoPtr_queueTimerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayTimingHandler>.NativeClassPtr, "queueTimerDisplay");
			RankedPlayTimingHandler.NativeFieldInfoPtr_queueTimerHeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayTimingHandler>.NativeClassPtr, "queueTimerHeader");
			RankedPlayTimingHandler.NativeFieldInfoPtr_headerQueueClosedLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayTimingHandler>.NativeClassPtr, "headerQueueClosedLoc");
			RankedPlayTimingHandler.NativeFieldInfoPtr_headerQueueOpenLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayTimingHandler>.NativeClassPtr, "headerQueueOpenLoc");
			RankedPlayTimingHandler.NativeFieldInfoPtr_gamesStartingLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayTimingHandler>.NativeClassPtr, "gamesStartingLoc");
			RankedPlayTimingHandler.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayTimingHandler>.NativeClassPtr, 100663423);
			RankedPlayTimingHandler.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayTimingHandler>.NativeClassPtr, 100663424);
			RankedPlayTimingHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayTimingHandler>.NativeClassPtr, 100663425);
			RankedPlayTimingHandler.NativeMethodInfoPtr__dirtyUpdate_b__6_0_Private_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayTimingHandler>.NativeClassPtr, 100663426);
			RankedPlayTimingHandler.NativeMethodInfoPtr__dirtyUpdate_b__6_1_Private_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayTimingHandler>.NativeClassPtr, 100663427);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00007868 File Offset: 0x00005A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225580, XrefRangeEnd = 1225592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedPlayTimingHandler.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000078A4 File Offset: 0x00005AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225592, XrefRangeEnd = 1225628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedPlayTimingHandler.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000078E0 File Offset: 0x00005AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225628, XrefRangeEnd = 1225638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedPlayTimingHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayTimingHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayTimingHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000791C File Offset: 0x00005B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225638, XrefRangeEnd = 1225644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan _dirtyUpdate_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayTimingHandler.NativeMethodInfoPtr__dirtyUpdate_b__6_0_Private_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00007958 File Offset: 0x00005B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225644, XrefRangeEnd = 1225650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan _dirtyUpdate_b__6_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayTimingHandler.NativeMethodInfoPtr__dirtyUpdate_b__6_1_Private_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002DBF File Offset: 0x00000FBF
		public RankedPlayTimingHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00007994 File Offset: 0x00005B94
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002DC8 File Offset: 0x00000FC8
		public unsafe TimerDisplay queueTimerDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayTimingHandler.NativeFieldInfoPtr_queueTimerDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayTimingHandler.NativeFieldInfoPtr_queueTimerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000079C4 File Offset: 0x00005BC4
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002DE7 File Offset: 0x00000FE7
		public unsafe TMP_Text queueTimerHeader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayTimingHandler.NativeFieldInfoPtr_queueTimerHeader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayTimingHandler.NativeFieldInfoPtr_queueTimerHeader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600017C RID: 380 RVA: 0x000079F4 File Offset: 0x00005BF4
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00002E06 File Offset: 0x00001006
		public unsafe string headerQueueClosedLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayTimingHandler.NativeFieldInfoPtr_headerQueueClosedLoc);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayTimingHandler.NativeFieldInfoPtr_headerQueueClosedLoc), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00007A1C File Offset: 0x00005C1C
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002E25 File Offset: 0x00001025
		public unsafe string headerQueueOpenLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayTimingHandler.NativeFieldInfoPtr_headerQueueOpenLoc);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayTimingHandler.NativeFieldInfoPtr_headerQueueOpenLoc), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00007A44 File Offset: 0x00005C44
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00002E44 File Offset: 0x00001044
		public unsafe string gamesStartingLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayTimingHandler.NativeFieldInfoPtr_gamesStartingLoc);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayTimingHandler.NativeFieldInfoPtr_gamesStartingLoc), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_queueTimerDisplay;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_queueTimerHeader;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_headerQueueClosedLoc;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_headerQueueOpenLoc;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_gamesStartingLoc;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__6_0_Private_TimeSpan_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__6_1_Private_TimeSpan_0;
	}
}
