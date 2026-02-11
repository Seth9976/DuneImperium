using System;
using Canis.utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine;

namespace dwd.core.input.multitouch
{
	// Token: 0x0200006B RID: 107
	public sealed class MutableGesture : VersionedModel
	{
		// Token: 0x06000413 RID: 1043 RVA: 0x0001386C File Offset: 0x00011A6C
		// Note: this type is marked as 'beforefieldinit'.
		static MutableGesture()
		{
			Il2CppClassPointerStore<MutableGesture>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.multitouch", "MutableGesture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr);
			MutableGesture.NativeFieldInfoPtr_updateGesture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, "updateGesture");
			MutableGesture.NativeFieldInfoPtr_touches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, "touches");
			MutableGesture.NativeFieldInfoPtr_readOnlyTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, "readOnlyTouches");
			MutableGesture.NativeFieldInfoPtr_cachedPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, "cachedPositions");
			MutableGesture.NativeFieldInfoPtr_previousPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, "previousPositions");
			MutableGesture.NativeFieldInfoPtr_readOnlyPreviousPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, "readOnlyPreviousPositions");
			MutableGesture.NativeFieldInfoPtr_RequiredFingers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, "RequiredFingers");
			MutableGesture.NativeFieldInfoPtr_asReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, "asReadOnly");
			MutableGesture.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, 100663754);
			MutableGesture.NativeMethodInfoPtr__ctor_Public_Void_Int32_List_1_TouchPress_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, 100663755);
			MutableGesture.NativeMethodInfoPtr_AddTouch_Public_Void_TouchPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, 100663756);
			MutableGesture.NativeMethodInfoPtr_RemoveTouch_Public_Void_TouchPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, 100663757);
			MutableGesture.NativeMethodInfoPtr_GetTouches_Public_ReadOnlyCollection_1_TouchPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, 100663758);
			MutableGesture.NativeMethodInfoPtr_GetPress_Public_TouchPress_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, 100663759);
			MutableGesture.NativeMethodInfoPtr_GetPreviousPositionLookup_Public_ReadOnlyDictionary_2_TouchPress_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, 100663760);
			MutableGesture.NativeMethodInfoPtr_UpdatePreviousPositions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, 100663761);
			MutableGesture.NativeMethodInfoPtr_get_AsReadOnly_Public_get_Gesture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr, 100663762);
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x000139F0 File Offset: 0x00011BF0
		public unsafe bool Active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122416, XrefRangeEnd = 1122417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableGesture.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00013A2C File Offset: 0x00011C2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1122453, RefRangeEnd = 1122455, XrefRangeStart = 1122417, XrefRangeEnd = 1122453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableGesture(int requiredFingers, List<TouchPress> currentTouches, Action updateGestureCallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableGesture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref requiredFingers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentTouches);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updateGestureCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableGesture.NativeMethodInfoPtr__ctor_Public_Void_Int32_List_1_TouchPress_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00013A98 File Offset: 0x00011C98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1122475, RefRangeEnd = 1122477, XrefRangeStart = 1122455, XrefRangeEnd = 1122475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTouch(TouchPress press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableGesture.NativeMethodInfoPtr_AddTouch_Public_Void_TouchPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00013ADC File Offset: 0x00011CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122477, XrefRangeEnd = 1122495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTouch(TouchPress press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableGesture.NativeMethodInfoPtr_RemoveTouch_Public_Void_TouchPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00013B20 File Offset: 0x00011D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122495, XrefRangeEnd = 1122499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<TouchPress> GetTouches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableGesture.NativeMethodInfoPtr_GetTouches_Public_ReadOnlyCollection_1_TouchPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TouchPress>>(intPtr3) : null;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00013B60 File Offset: 0x00011D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122499, XrefRangeEnd = 1122518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchPress GetPress(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableGesture.NativeMethodInfoPtr_GetPress_Public_TouchPress_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchPress>(intPtr3) : null;
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00013BAC File Offset: 0x00011DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122518, XrefRangeEnd = 1122525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe global::ReadOnlyDictionary<TouchPress, Vector2> GetPreviousPositionLookup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableGesture.NativeMethodInfoPtr_GetPreviousPositionLookup_Public_ReadOnlyDictionary_2_TouchPress_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::ReadOnlyDictionary<TouchPress, Vector2>>(intPtr3) : null;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00013BEC File Offset: 0x00011DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1122551, RefRangeEnd = 1122552, XrefRangeStart = 1122525, XrefRangeEnd = 1122551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePreviousPositions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableGesture.NativeMethodInfoPtr_UpdatePreviousPositions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00013C20 File Offset: 0x00011E20
		public unsafe Gesture AsReadOnly
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1122558, RefRangeEnd = 1122566, XrefRangeStart = 1122552, XrefRangeEnd = 1122558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableGesture.NativeMethodInfoPtr_get_AsReadOnly_Public_get_Gesture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gesture>(intPtr3) : null;
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00004577 File Offset: 0x00002777
		public MutableGesture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00013C60 File Offset: 0x00011E60
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00004580 File Offset: 0x00002780
		public unsafe Action updateGesture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_updateGesture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_updateGesture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00013C90 File Offset: 0x00011E90
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x0000459F File Offset: 0x0000279F
		public unsafe List<TouchPress> touches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_touches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TouchPress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_touches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00013CC0 File Offset: 0x00011EC0
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x000045BE File Offset: 0x000027BE
		public unsafe ReadOnlyCollection<TouchPress> readOnlyTouches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_readOnlyTouches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<TouchPress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_readOnlyTouches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00013CF0 File Offset: 0x00011EF0
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x000045DD File Offset: 0x000027DD
		public unsafe Dictionary<TouchPress, Vector2> cachedPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_cachedPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TouchPress, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_cachedPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00013D20 File Offset: 0x00011F20
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x000045FC File Offset: 0x000027FC
		public unsafe Dictionary<TouchPress, Vector2> previousPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_previousPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TouchPress, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_previousPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00013D50 File Offset: 0x00011F50
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x0000461B File Offset: 0x0000281B
		public unsafe global::ReadOnlyDictionary<TouchPress, Vector2> readOnlyPreviousPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_readOnlyPreviousPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::ReadOnlyDictionary<TouchPress, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_readOnlyPreviousPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00013D80 File Offset: 0x00011F80
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x0000463A File Offset: 0x0000283A
		public unsafe int RequiredFingers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_RequiredFingers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_RequiredFingers)) = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00013DA8 File Offset: 0x00011FA8
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00004655 File Offset: 0x00002855
		public unsafe Gesture asReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_asReadOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gesture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableGesture.NativeFieldInfoPtr_asReadOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_updateGesture;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_touches;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr_readOnlyTouches;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr_cachedPositions;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr_previousPositions;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_readOnlyPreviousPositions;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr_RequiredFingers;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_asReadOnly;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_get_Active_Public_get_Boolean_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_List_1_TouchPress_Action_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_AddTouch_Public_Void_TouchPress_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTouch_Public_Void_TouchPress_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_GetTouches_Public_ReadOnlyCollection_1_TouchPress_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_GetPress_Public_TouchPress_Int32_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousPositionLookup_Public_ReadOnlyDictionary_2_TouchPress_Vector2_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePreviousPositions_Public_Void_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_get_AsReadOnly_Public_get_Gesture_0;
	}
}
