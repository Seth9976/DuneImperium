using System;
using dwd.core.animation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Events;

namespace dwd.core.ui.prompt.behaviours
{
	// Token: 0x02000045 RID: 69
	public class VisibilityPromptAnimator : PromptBehaviour
	{
		// Token: 0x0600027E RID: 638 RVA: 0x0000BFC8 File Offset: 0x0000A1C8
		// Note: this type is marked as 'beforefieldinit'.
		static VisibilityPromptAnimator()
		{
			Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.behaviours", "VisibilityPromptAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr);
			VisibilityPromptAnimator.NativeFieldInfoPtr_blockingAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr, "blockingAnimation");
			VisibilityPromptAnimator.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr, "onOpen");
			VisibilityPromptAnimator.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr, "onClose");
			VisibilityPromptAnimator.NativeMethodInfoPtr_get_OpenAnimation_Public_get_BoolBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr, 100663604);
			VisibilityPromptAnimator.NativeMethodInfoPtr_set_OpenAnimation_Public_set_Void_BoolBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr, 100663605);
			VisibilityPromptAnimator.NativeMethodInfoPtr_AnimateOpen_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr, 100663606);
			VisibilityPromptAnimator.NativeMethodInfoPtr_AnimateClose_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr, 100663607);
			VisibilityPromptAnimator.NativeMethodInfoPtr_Animate_Public_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr, 100663608);
			VisibilityPromptAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr, 100663609);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000C0AC File Offset: 0x0000A2AC
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0000C0EC File Offset: 0x0000A2EC
		public unsafe BoolBlockingAnimation OpenAnimation
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator.NativeMethodInfoPtr_get_OpenAnimation_Public_get_BoolBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoolBlockingAnimation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator.NativeMethodInfoPtr_set_OpenAnimation_Public_set_Void_BoolBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000C130 File Offset: 0x0000A330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215015, XrefRangeEnd = 1215020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator AnimateOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisibilityPromptAnimator.NativeMethodInfoPtr_AnimateOpen_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000C17C File Offset: 0x0000A37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215020, XrefRangeEnd = 1215025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AnimateClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator.NativeMethodInfoPtr_AnimateClose_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000C1BC File Offset: 0x0000A3BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1215030, RefRangeEnd = 1215032, XrefRangeStart = 1215025, XrefRangeEnd = 1215030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Animate(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref open;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator.NativeMethodInfoPtr_Animate_Public_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000C208 File Offset: 0x0000A408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215032, XrefRangeEnd = 1215042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityPromptAnimator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00003401 File Offset: 0x00001601
		public VisibilityPromptAnimator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000C244 File Offset: 0x0000A444
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000340A File Offset: 0x0000160A
		public unsafe BoolBlockingAnimation blockingAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator.NativeFieldInfoPtr_blockingAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolBlockingAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator.NativeFieldInfoPtr_blockingAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000C274 File Offset: 0x0000A474
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00003429 File Offset: 0x00001629
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00003448 File Offset: 0x00001648
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_blockingAnimation;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenAnimation_Public_get_BoolBlockingAnimation_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenAnimation_Public_set_Void_BoolBlockingAnimation_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_AnimateOpen_Public_Virtual_New_IEnumerator_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_AnimateClose_Public_IEnumerator_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_Animate_Public_IEnumerator_Boolean_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200005E RID: 94
		[ObfuscatedName("dwd.core.ui.prompt.behaviours.VisibilityPromptAnimator+<Animate>d__8")]
		public sealed class _Animate_d__8 : Object
		{
			// Token: 0x060003B3 RID: 947 RVA: 0x0000FABC File Offset: 0x0000DCBC
			// Note: this type is marked as 'beforefieldinit'.
			static _Animate_d__8()
			{
				Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr, "<Animate>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr);
				VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr, "<>1__state");
				VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr, "<>2__current");
				VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr, "<>4__this");
				VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr, "open");
				VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr__block_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr, "<block>5__2");
				VisibilityPromptAnimator._Animate_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr, 100663610);
				VisibilityPromptAnimator._Animate_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr, 100663611);
				VisibilityPromptAnimator._Animate_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr, 100663612);
				VisibilityPromptAnimator._Animate_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr, 100663613);
				VisibilityPromptAnimator._Animate_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr, 100663614);
				VisibilityPromptAnimator._Animate_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr, 100663615);
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x0000FBC4 File Offset: 0x0000DDC4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Animate_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibilityPromptAnimator._Animate_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._Animate_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x0000FC0C File Offset: 0x0000DE0C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._Animate_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x0000FC40 File Offset: 0x0000DE40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214975, XrefRangeEnd = 1214986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._Animate_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x060003B7 RID: 951 RVA: 0x0000FC7C File Offset: 0x0000DE7C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._Animate_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x0000FCBC File Offset: 0x0000DEBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214986, XrefRangeEnd = 1214991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._Animate_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x060003B9 RID: 953 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._Animate_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003BA RID: 954 RVA: 0x00003E07 File Offset: 0x00002007
			public _Animate_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x060003BB RID: 955 RVA: 0x0000FD30 File Offset: 0x0000DF30
			// (set) Token: 0x060003BC RID: 956 RVA: 0x00003E10 File Offset: 0x00002010
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x060003BD RID: 957 RVA: 0x0000FD58 File Offset: 0x0000DF58
			// (set) Token: 0x060003BE RID: 958 RVA: 0x00003E2B File Offset: 0x0000202B
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x060003BF RID: 959 RVA: 0x0000FD88 File Offset: 0x0000DF88
			// (set) Token: 0x060003C0 RID: 960 RVA: 0x00003E4A File Offset: 0x0000204A
			public unsafe VisibilityPromptAnimator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityPromptAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x060003C1 RID: 961 RVA: 0x0000FDB8 File Offset: 0x0000DFB8
			// (set) Token: 0x060003C2 RID: 962 RVA: 0x00003E69 File Offset: 0x00002069
			public unsafe bool open
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr_open);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr_open)) = value;
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x060003C3 RID: 963 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
			// (set) Token: 0x060003C4 RID: 964 RVA: 0x00003E84 File Offset: 0x00002084
			public unsafe IEnumerator _block_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr__block_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._Animate_d__8.NativeFieldInfoPtr__block_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000217 RID: 535
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000218 RID: 536
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000219 RID: 537
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400021A RID: 538
			private static readonly IntPtr NativeFieldInfoPtr_open;

			// Token: 0x0400021B RID: 539
			private static readonly IntPtr NativeFieldInfoPtr__block_5__2;

			// Token: 0x0400021C RID: 540
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400021D RID: 541
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400021E RID: 542
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400021F RID: 543
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000220 RID: 544
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000221 RID: 545
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200005F RID: 95
		[ObfuscatedName("dwd.core.ui.prompt.behaviours.VisibilityPromptAnimator+<AnimateClose>d__7")]
		public sealed class _AnimateClose_d__7 : Object
		{
			// Token: 0x060003C5 RID: 965 RVA: 0x0000FE10 File Offset: 0x0000E010
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateClose_d__7()
			{
				Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateClose_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr, "<AnimateClose>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateClose_d__7>.NativeClassPtr);
				VisibilityPromptAnimator._AnimateClose_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateClose_d__7>.NativeClassPtr, "<>1__state");
				VisibilityPromptAnimator._AnimateClose_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateClose_d__7>.NativeClassPtr, "<>2__current");
				VisibilityPromptAnimator._AnimateClose_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateClose_d__7>.NativeClassPtr, "<>4__this");
				VisibilityPromptAnimator._AnimateClose_d__7.NativeFieldInfoPtr__animate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateClose_d__7>.NativeClassPtr, "<animate>5__2");
				VisibilityPromptAnimator._AnimateClose_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateClose_d__7>.NativeClassPtr, 100663616);
				VisibilityPromptAnimator._AnimateClose_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateClose_d__7>.NativeClassPtr, 100663617);
				VisibilityPromptAnimator._AnimateClose_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateClose_d__7>.NativeClassPtr, 100663618);
				VisibilityPromptAnimator._AnimateClose_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateClose_d__7>.NativeClassPtr, 100663619);
				VisibilityPromptAnimator._AnimateClose_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateClose_d__7>.NativeClassPtr, 100663620);
				VisibilityPromptAnimator._AnimateClose_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateClose_d__7>.NativeClassPtr, 100663621);
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x0000FF04 File Offset: 0x0000E104
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateClose_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateClose_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._AnimateClose_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x0000FF4C File Offset: 0x0000E14C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._AnimateClose_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x0000FF80 File Offset: 0x0000E180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214991, XrefRangeEnd = 1214998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._AnimateClose_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x060003C9 RID: 969 RVA: 0x0000FFBC File Offset: 0x0000E1BC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._AnimateClose_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003CA RID: 970 RVA: 0x0000FFFC File Offset: 0x0000E1FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214998, XrefRangeEnd = 1215003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._AnimateClose_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x060003CB RID: 971 RVA: 0x00010030 File Offset: 0x0000E230
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._AnimateClose_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003CC RID: 972 RVA: 0x00003EA3 File Offset: 0x000020A3
			public _AnimateClose_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x060003CD RID: 973 RVA: 0x00010070 File Offset: 0x0000E270
			// (set) Token: 0x060003CE RID: 974 RVA: 0x00003EAC File Offset: 0x000020AC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateClose_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateClose_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x060003CF RID: 975 RVA: 0x00010098 File Offset: 0x0000E298
			// (set) Token: 0x060003D0 RID: 976 RVA: 0x00003EC7 File Offset: 0x000020C7
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateClose_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateClose_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x060003D1 RID: 977 RVA: 0x000100C8 File Offset: 0x0000E2C8
			// (set) Token: 0x060003D2 RID: 978 RVA: 0x00003EE6 File Offset: 0x000020E6
			public unsafe VisibilityPromptAnimator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateClose_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityPromptAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateClose_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x060003D3 RID: 979 RVA: 0x000100F8 File Offset: 0x0000E2F8
			// (set) Token: 0x060003D4 RID: 980 RVA: 0x00003F05 File Offset: 0x00002105
			public unsafe IEnumerator _animate_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateClose_d__7.NativeFieldInfoPtr__animate_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateClose_d__7.NativeFieldInfoPtr__animate_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000222 RID: 546
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000223 RID: 547
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000224 RID: 548
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000225 RID: 549
			private static readonly IntPtr NativeFieldInfoPtr__animate_5__2;

			// Token: 0x04000226 RID: 550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000227 RID: 551
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000228 RID: 552
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000229 RID: 553
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400022A RID: 554
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400022B RID: 555
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000060 RID: 96
		[ObfuscatedName("dwd.core.ui.prompt.behaviours.VisibilityPromptAnimator+<AnimateOpen>d__6")]
		public sealed class _AnimateOpen_d__6 : Object
		{
			// Token: 0x060003D5 RID: 981 RVA: 0x00010128 File Offset: 0x0000E328
			// Note: this type is marked as 'beforefieldinit'.
			static _AnimateOpen_d__6()
			{
				Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateOpen_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VisibilityPromptAnimator>.NativeClassPtr, "<AnimateOpen>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateOpen_d__6>.NativeClassPtr);
				VisibilityPromptAnimator._AnimateOpen_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateOpen_d__6>.NativeClassPtr, "<>1__state");
				VisibilityPromptAnimator._AnimateOpen_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateOpen_d__6>.NativeClassPtr, "<>2__current");
				VisibilityPromptAnimator._AnimateOpen_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateOpen_d__6>.NativeClassPtr, "<>4__this");
				VisibilityPromptAnimator._AnimateOpen_d__6.NativeFieldInfoPtr__animate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateOpen_d__6>.NativeClassPtr, "<animate>5__2");
				VisibilityPromptAnimator._AnimateOpen_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateOpen_d__6>.NativeClassPtr, 100663622);
				VisibilityPromptAnimator._AnimateOpen_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateOpen_d__6>.NativeClassPtr, 100663623);
				VisibilityPromptAnimator._AnimateOpen_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateOpen_d__6>.NativeClassPtr, 100663624);
				VisibilityPromptAnimator._AnimateOpen_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateOpen_d__6>.NativeClassPtr, 100663625);
				VisibilityPromptAnimator._AnimateOpen_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateOpen_d__6>.NativeClassPtr, 100663626);
				VisibilityPromptAnimator._AnimateOpen_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateOpen_d__6>.NativeClassPtr, 100663627);
			}

			// Token: 0x060003D6 RID: 982 RVA: 0x0001021C File Offset: 0x0000E41C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AnimateOpen_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibilityPromptAnimator._AnimateOpen_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._AnimateOpen_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003D7 RID: 983 RVA: 0x00010264 File Offset: 0x0000E464
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._AnimateOpen_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003D8 RID: 984 RVA: 0x00010298 File Offset: 0x0000E498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215003, XrefRangeEnd = 1215010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._AnimateOpen_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x060003D9 RID: 985 RVA: 0x000102D4 File Offset: 0x0000E4D4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._AnimateOpen_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003DA RID: 986 RVA: 0x00010314 File Offset: 0x0000E514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215010, XrefRangeEnd = 1215015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._AnimateOpen_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x060003DB RID: 987 RVA: 0x00010348 File Offset: 0x0000E548
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityPromptAnimator._AnimateOpen_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060003DC RID: 988 RVA: 0x00003F24 File Offset: 0x00002124
			public _AnimateOpen_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x060003DD RID: 989 RVA: 0x00010388 File Offset: 0x0000E588
			// (set) Token: 0x060003DE RID: 990 RVA: 0x00003F2D File Offset: 0x0000212D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateOpen_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateOpen_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x060003DF RID: 991 RVA: 0x000103B0 File Offset: 0x0000E5B0
			// (set) Token: 0x060003E0 RID: 992 RVA: 0x00003F48 File Offset: 0x00002148
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateOpen_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateOpen_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x060003E1 RID: 993 RVA: 0x000103E0 File Offset: 0x0000E5E0
			// (set) Token: 0x060003E2 RID: 994 RVA: 0x00003F67 File Offset: 0x00002167
			public unsafe VisibilityPromptAnimator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateOpen_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityPromptAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateOpen_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x00010410 File Offset: 0x0000E610
			// (set) Token: 0x060003E4 RID: 996 RVA: 0x00003F86 File Offset: 0x00002186
			public unsafe IEnumerator _animate_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateOpen_d__6.NativeFieldInfoPtr__animate_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityPromptAnimator._AnimateOpen_d__6.NativeFieldInfoPtr__animate_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400022C RID: 556
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400022D RID: 557
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400022E RID: 558
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400022F RID: 559
			private static readonly IntPtr NativeFieldInfoPtr__animate_5__2;

			// Token: 0x04000230 RID: 560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000231 RID: 561
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000232 RID: 562
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000233 RID: 563
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000234 RID: 564
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000235 RID: 565
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
