using System;
using dwd.core.input.compositeModule.navigation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.input
{
	// Token: 0x0200003A RID: 58
	public class DelayRepeatedInputDirection : MonoBehaviour
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x0000C7C0 File Offset: 0x0000A9C0
		// Note: this type is marked as 'beforefieldinit'.
		static DelayRepeatedInputDirection()
		{
			Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "DelayRepeatedInputDirection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr);
			DelayRepeatedInputDirection.NativeFieldInfoPtr_selectionNavigator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr, "selectionNavigator");
			DelayRepeatedInputDirection.NativeFieldInfoPtr_minInputThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr, "minInputThreshold");
			DelayRepeatedInputDirection.NativeFieldInfoPtr_preventInputDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr, "preventInputDirection");
			DelayRepeatedInputDirection.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr, "initialized");
			DelayRepeatedInputDirection.NativeFieldInfoPtr_OnValidInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr, "OnValidInput");
			DelayRepeatedInputDirection.NativeFieldInfoPtr_waitingForDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr, "waitingForDelay");
			DelayRepeatedInputDirection.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr, 100663534);
			DelayRepeatedInputDirection.NativeMethodInfoPtr_Event_HandleInput_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr, 100663535);
			DelayRepeatedInputDirection.NativeMethodInfoPtr_DelaySimilarInput_Private_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr, 100663536);
			DelayRepeatedInputDirection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr, 100663537);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120321, XrefRangeEnd = 1120325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayRepeatedInputDirection.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000C8EC File Offset: 0x0000AAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120325, XrefRangeEnd = 1120337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_HandleInput(float direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayRepeatedInputDirection.NativeMethodInfoPtr_Event_HandleInput_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000C92C File Offset: 0x0000AB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120337, XrefRangeEnd = 1120342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelaySimilarInput(int direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayRepeatedInputDirection.NativeMethodInfoPtr_DelaySimilarInput_Private_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000C978 File Offset: 0x0000AB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120342, XrefRangeEnd = 1120343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelayRepeatedInputDirection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayRepeatedInputDirection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00003023 File Offset: 0x00001223
		public DelayRepeatedInputDirection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000C9B4 File Offset: 0x0000ABB4
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0000302C File Offset: 0x0000122C
		public unsafe AxialSelectionNavigator selectionNavigator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection.NativeFieldInfoPtr_selectionNavigator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AxialSelectionNavigator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection.NativeFieldInfoPtr_selectionNavigator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000C9E4 File Offset: 0x0000ABE4
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0000304B File Offset: 0x0000124B
		public unsafe float minInputThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection.NativeFieldInfoPtr_minInputThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection.NativeFieldInfoPtr_minInputThreshold)) = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000CA0C File Offset: 0x0000AC0C
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00003066 File Offset: 0x00001266
		public unsafe int preventInputDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection.NativeFieldInfoPtr_preventInputDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection.NativeFieldInfoPtr_preventInputDirection)) = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000CA34 File Offset: 0x0000AC34
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00003081 File Offset: 0x00001281
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000CA5C File Offset: 0x0000AC5C
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0000309C File Offset: 0x0000129C
		public unsafe UnityEventFloat OnValidInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection.NativeFieldInfoPtr_OnValidInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventFloat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection.NativeFieldInfoPtr_OnValidInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000CA8C File Offset: 0x0000AC8C
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x000030BB File Offset: 0x000012BB
		public unsafe Coroutine waitingForDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection.NativeFieldInfoPtr_waitingForDelay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection.NativeFieldInfoPtr_waitingForDelay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_selectionNavigator;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_minInputThreshold;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_preventInputDirection;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeFieldInfoPtr_OnValidInput;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeFieldInfoPtr_waitingForDelay;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_Event_HandleInput_Public_Void_Single_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_DelaySimilarInput_Private_IEnumerator_Int32_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000BF RID: 191
		[ObfuscatedName("dwd.core.input.DelayRepeatedInputDirection+<DelaySimilarInput>d__8")]
		public sealed class _DelaySimilarInput_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x060008A8 RID: 2216 RVA: 0x00022E74 File Offset: 0x00021074
			// Note: this type is marked as 'beforefieldinit'.
			static _DelaySimilarInput_d__8()
			{
				Il2CppClassPointerStore<DelayRepeatedInputDirection._DelaySimilarInput_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DelayRepeatedInputDirection>.NativeClassPtr, "<DelaySimilarInput>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayRepeatedInputDirection._DelaySimilarInput_d__8>.NativeClassPtr);
				DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayRepeatedInputDirection._DelaySimilarInput_d__8>.NativeClassPtr, "<>1__state");
				DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayRepeatedInputDirection._DelaySimilarInput_d__8>.NativeClassPtr, "<>2__current");
				DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayRepeatedInputDirection._DelaySimilarInput_d__8>.NativeClassPtr, "<>4__this");
				DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayRepeatedInputDirection._DelaySimilarInput_d__8>.NativeClassPtr, "direction");
				DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayRepeatedInputDirection._DelaySimilarInput_d__8>.NativeClassPtr, 100663538);
				DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayRepeatedInputDirection._DelaySimilarInput_d__8>.NativeClassPtr, 100663539);
				DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayRepeatedInputDirection._DelaySimilarInput_d__8>.NativeClassPtr, 100663540);
				DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayRepeatedInputDirection._DelaySimilarInput_d__8>.NativeClassPtr, 100663541);
				DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayRepeatedInputDirection._DelaySimilarInput_d__8>.NativeClassPtr, 100663542);
				DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayRepeatedInputDirection._DelaySimilarInput_d__8>.NativeClassPtr, 100663543);
			}

			// Token: 0x060008A9 RID: 2217 RVA: 0x00022F68 File Offset: 0x00021168
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelaySimilarInput_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayRepeatedInputDirection._DelaySimilarInput_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060008AA RID: 2218 RVA: 0x00022FB0 File Offset: 0x000211B0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060008AB RID: 2219 RVA: 0x00022FE4 File Offset: 0x000211E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120311, XrefRangeEnd = 1120316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x060008AC RID: 2220 RVA: 0x00023020 File Offset: 0x00021220
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060008AD RID: 2221 RVA: 0x00023060 File Offset: 0x00021260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120316, XrefRangeEnd = 1120321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000283 RID: 643
			// (get) Token: 0x060008AE RID: 2222 RVA: 0x00023094 File Offset: 0x00021294
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060008AF RID: 2223 RVA: 0x0000688B File Offset: 0x00004A8B
			public _DelaySimilarInput_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700027E RID: 638
			// (get) Token: 0x060008B0 RID: 2224 RVA: 0x000230D4 File Offset: 0x000212D4
			// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00006894 File Offset: 0x00004A94
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700027F RID: 639
			// (get) Token: 0x060008B2 RID: 2226 RVA: 0x000230FC File Offset: 0x000212FC
			// (set) Token: 0x060008B3 RID: 2227 RVA: 0x000068AF File Offset: 0x00004AAF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000280 RID: 640
			// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0002312C File Offset: 0x0002132C
			// (set) Token: 0x060008B5 RID: 2229 RVA: 0x000068CE File Offset: 0x00004ACE
			public unsafe DelayRepeatedInputDirection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelayRepeatedInputDirection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000281 RID: 641
			// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0002315C File Offset: 0x0002135C
			// (set) Token: 0x060008B7 RID: 2231 RVA: 0x000068ED File Offset: 0x00004AED
			public unsafe int direction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeFieldInfoPtr_direction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DelayRepeatedInputDirection._DelaySimilarInput_d__8.NativeFieldInfoPtr_direction)) = value;
				}
			}

			// Token: 0x04000551 RID: 1361
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000552 RID: 1362
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000553 RID: 1363
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000554 RID: 1364
			private static readonly IntPtr NativeFieldInfoPtr_direction;

			// Token: 0x04000555 RID: 1365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000556 RID: 1366
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000557 RID: 1367
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000558 RID: 1368
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000559 RID: 1369
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400055A RID: 1370
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
