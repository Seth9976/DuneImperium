using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine;

namespace dwd.core.input.multitouch
{
	// Token: 0x02000067 RID: 103
	public sealed class Gesture : global::Il2CppSystem.Object
	{
		// Token: 0x060003DE RID: 990 RVA: 0x00012D40 File Offset: 0x00010F40
		// Note: this type is marked as 'beforefieldinit'.
		static Gesture()
		{
			Il2CppClassPointerStore<Gesture>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.multitouch", "Gesture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gesture>.NativeClassPtr);
			Gesture.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gesture>.NativeClassPtr, "source");
			Gesture.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gesture>.NativeClassPtr, 100663728);
			Gesture.NativeMethodInfoPtr__ctor_Public_Void_MutableGesture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gesture>.NativeClassPtr, 100663729);
			Gesture.NativeMethodInfoPtr_GetTouches_Public_ReadOnlyCollection_1_TouchPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gesture>.NativeClassPtr, 100663730);
			Gesture.NativeMethodInfoPtr_GetPress_Public_TouchPress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gesture>.NativeClassPtr, 100663731);
			Gesture.NativeMethodInfoPtr_GetPreviousPositionLookup_Public_ReadOnlyDictionary_2_TouchPress_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gesture>.NativeClassPtr, 100663732);
			Gesture.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gesture>.NativeClassPtr, 100663733);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00012DFC File Offset: 0x00010FFC
		public unsafe bool Active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122111, XrefRangeEnd = 1122112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gesture.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00012E38 File Offset: 0x00011038
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gesture(MutableGesture source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gesture>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gesture.NativeMethodInfoPtr__ctor_Public_Void_MutableGesture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00012E84 File Offset: 0x00011084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1122116, RefRangeEnd = 1122117, XrefRangeStart = 1122112, XrefRangeEnd = 1122116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<TouchPress> GetTouches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gesture.NativeMethodInfoPtr_GetTouches_Public_ReadOnlyCollection_1_TouchPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TouchPress>>(intPtr3) : null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00012EC4 File Offset: 0x000110C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122117, XrefRangeEnd = 1122136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchPress GetPress(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gesture.NativeMethodInfoPtr_GetPress_Public_TouchPress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchPress>(intPtr3) : null;
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00012F10 File Offset: 0x00011110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1122143, RefRangeEnd = 1122145, XrefRangeStart = 1122136, XrefRangeEnd = 1122143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe global::ReadOnlyDictionary<TouchPress, Vector2> GetPreviousPositionLookup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gesture.NativeMethodInfoPtr_GetPreviousPositionLookup_Public_ReadOnlyDictionary_2_TouchPress_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::ReadOnlyDictionary<TouchPress, Vector2>>(intPtr3) : null;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00012F50 File Offset: 0x00011150
		public unsafe ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gesture.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00004406 File Offset: 0x00002606
		public Gesture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00012F8C File Offset: 0x0001118C
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x0000440F File Offset: 0x0000260F
		public unsafe MutableGesture source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gesture.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableGesture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gesture.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_get_Active_Public_get_Boolean_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MutableGesture_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_GetTouches_Public_ReadOnlyCollection_1_TouchPress_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_GetPress_Public_TouchPress_Int32_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousPositionLookup_Public_ReadOnlyDictionary_2_TouchPress_Vector2_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;
	}
}
