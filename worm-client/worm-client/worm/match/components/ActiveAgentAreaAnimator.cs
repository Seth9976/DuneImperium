using System;
using boardgames.match.selection;
using dwd.core.Model;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001AA RID: 426
	public class ActiveAgentAreaAnimator : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x060012D6 RID: 4822 RVA: 0x00051508 File Offset: 0x0004F708
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveAgentAreaAnimator()
		{
			Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "ActiveAgentAreaAnimator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr);
			ActiveAgentAreaAnimator.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr, "view");
			ActiveAgentAreaAnimator.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr, "animator");
			ActiveAgentAreaAnimator.NativeFieldInfoPtr_siblingCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr, "siblingCount");
			ActiveAgentAreaAnimator.NativeFieldInfoPtr_ActiveParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr, "ActiveParam");
			ActiveAgentAreaAnimator.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr, 100665865);
			ActiveAgentAreaAnimator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr, 100665866);
			ActiveAgentAreaAnimator.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr, 100665867);
			ActiveAgentAreaAnimator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr, 100665868);
			ActiveAgentAreaAnimator.NativeMethodInfoPtr_DelayedUpdate_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr, 100665869);
			ActiveAgentAreaAnimator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr, 100665870);
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x00051600 File Offset: 0x0004F800
		public unsafe override ulong currentModelVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712462, XrefRangeEnd = 712466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAgentAreaAnimator.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00051648 File Offset: 0x0004F848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712466, XrefRangeEnd = 712480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAgentAreaAnimator.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00051684 File Offset: 0x0004F884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712480, XrefRangeEnd = 712502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAgentAreaAnimator.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x000516C0 File Offset: 0x0004F8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712502, XrefRangeEnd = 712508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAgentAreaAnimator.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x000516FC File Offset: 0x0004F8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712508, XrefRangeEnd = 712513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAgentAreaAnimator.NativeMethodInfoPtr_DelayedUpdate_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x0005173C File Offset: 0x0004F93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712513, XrefRangeEnd = 712523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveAgentAreaAnimator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAgentAreaAnimator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0000BBCB File Offset: 0x00009DCB
		public ActiveAgentAreaAnimator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x00051778 File Offset: 0x0004F978
		// (set) Token: 0x060012DF RID: 4831 RVA: 0x0000BBD4 File Offset: 0x00009DD4
		public unsafe EntityView view
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAgentAreaAnimator.NativeFieldInfoPtr_view);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAgentAreaAnimator.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x000517A8 File Offset: 0x0004F9A8
		// (set) Token: 0x060012E1 RID: 4833 RVA: 0x0000BBF3 File Offset: 0x00009DF3
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAgentAreaAnimator.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAgentAreaAnimator.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x000517D8 File Offset: 0x0004F9D8
		// (set) Token: 0x060012E3 RID: 4835 RVA: 0x0000BC12 File Offset: 0x00009E12
		public unsafe VersionedValue<int> siblingCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAgentAreaAnimator.NativeFieldInfoPtr_siblingCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedValue<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAgentAreaAnimator.NativeFieldInfoPtr_siblingCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00051808 File Offset: 0x0004FA08
		// (set) Token: 0x060012E5 RID: 4837 RVA: 0x0000BC31 File Offset: 0x00009E31
		public unsafe static int ActiveParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ActiveAgentAreaAnimator.NativeFieldInfoPtr_ActiveParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActiveAgentAreaAnimator.NativeFieldInfoPtr_ActiveParam, (void*)(&value));
			}
		}

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeFieldInfoPtr_view;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeFieldInfoPtr_siblingCount;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeFieldInfoPtr_ActiveParam;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_DelayedUpdate_Private_IEnumerator_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003C0 RID: 960
		[ObfuscatedName("worm.match.components.ActiveAgentAreaAnimator+<DelayedUpdate>d__9")]
		public sealed class _DelayedUpdate_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x060026C4 RID: 9924 RVA: 0x0008DC70 File Offset: 0x0008BE70
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedUpdate_d__9()
			{
				Il2CppClassPointerStore<ActiveAgentAreaAnimator._DelayedUpdate_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActiveAgentAreaAnimator>.NativeClassPtr, "<DelayedUpdate>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveAgentAreaAnimator._DelayedUpdate_d__9>.NativeClassPtr);
				ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAgentAreaAnimator._DelayedUpdate_d__9>.NativeClassPtr, "<>1__state");
				ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAgentAreaAnimator._DelayedUpdate_d__9>.NativeClassPtr, "<>2__current");
				ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAgentAreaAnimator._DelayedUpdate_d__9>.NativeClassPtr, "<>4__this");
				ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAgentAreaAnimator._DelayedUpdate_d__9>.NativeClassPtr, 100665872);
				ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAgentAreaAnimator._DelayedUpdate_d__9>.NativeClassPtr, 100665873);
				ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAgentAreaAnimator._DelayedUpdate_d__9>.NativeClassPtr, 100665874);
				ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAgentAreaAnimator._DelayedUpdate_d__9>.NativeClassPtr, 100665875);
				ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAgentAreaAnimator._DelayedUpdate_d__9>.NativeClassPtr, 100665876);
				ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAgentAreaAnimator._DelayedUpdate_d__9>.NativeClassPtr, 100665877);
			}

			// Token: 0x060026C5 RID: 9925 RVA: 0x0008DD50 File Offset: 0x0008BF50
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedUpdate_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveAgentAreaAnimator._DelayedUpdate_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060026C6 RID: 9926 RVA: 0x0008DD98 File Offset: 0x0008BF98
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026C7 RID: 9927 RVA: 0x0008DDCC File Offset: 0x0008BFCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712449, XrefRangeEnd = 712457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AC8 RID: 2760
			// (get) Token: 0x060026C8 RID: 9928 RVA: 0x0008DE08 File Offset: 0x0008C008
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026C9 RID: 9929 RVA: 0x0008DE48 File Offset: 0x0008C048
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712457, XrefRangeEnd = 712462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AC9 RID: 2761
			// (get) Token: 0x060026CA RID: 9930 RVA: 0x0008DE7C File Offset: 0x0008C07C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060026CB RID: 9931 RVA: 0x000155FE File Offset: 0x000137FE
			public _DelayedUpdate_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AC5 RID: 2757
			// (get) Token: 0x060026CC RID: 9932 RVA: 0x0008DEBC File Offset: 0x0008C0BC
			// (set) Token: 0x060026CD RID: 9933 RVA: 0x00015607 File Offset: 0x00013807
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AC6 RID: 2758
			// (get) Token: 0x060026CE RID: 9934 RVA: 0x0008DEE4 File Offset: 0x0008C0E4
			// (set) Token: 0x060026CF RID: 9935 RVA: 0x00015622 File Offset: 0x00013822
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AC7 RID: 2759
			// (get) Token: 0x060026D0 RID: 9936 RVA: 0x0008DF14 File Offset: 0x0008C114
			// (set) Token: 0x060026D1 RID: 9937 RVA: 0x00015641 File Offset: 0x00013841
			public unsafe ActiveAgentAreaAnimator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActiveAgentAreaAnimator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAgentAreaAnimator._DelayedUpdate_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001652 RID: 5714
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001653 RID: 5715
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001654 RID: 5716
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001655 RID: 5717
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001656 RID: 5718
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001657 RID: 5719
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001658 RID: 5720
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001659 RID: 5721
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400165A RID: 5722
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
