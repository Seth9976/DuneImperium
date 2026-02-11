using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x02000012 RID: 18
	public class TriggeredBlockingAnimation : BlockingAnimation
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00004D44 File Offset: 0x00002F44
		// Note: this type is marked as 'beforefieldinit'.
		static TriggeredBlockingAnimation()
		{
			Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "TriggeredBlockingAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr);
			TriggeredBlockingAnimation.NativeFieldInfoPtr_maxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, "maxDuration");
			TriggeredBlockingAnimation.NativeFieldInfoPtr__Animator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, "<Animator>k__BackingField");
			TriggeredBlockingAnimation.NativeFieldInfoPtr_triggerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, "triggerName");
			TriggeredBlockingAnimation.NativeFieldInfoPtr_debugLogWhileBlocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, "debugLogWhileBlocking");
			TriggeredBlockingAnimation.NativeFieldInfoPtr_parameterHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, "parameterHash");
			TriggeredBlockingAnimation.NativeMethodInfoPtr_get_Animator_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, 100663373);
			TriggeredBlockingAnimation.NativeMethodInfoPtr_set_Animator_Private_set_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, 100663374);
			TriggeredBlockingAnimation.NativeMethodInfoPtr_get_TriggerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, 100663375);
			TriggeredBlockingAnimation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, 100663376);
			TriggeredBlockingAnimation.NativeMethodInfoPtr_WaitForAnimatorInitialized_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, 100663377);
			TriggeredBlockingAnimation.NativeMethodInfoPtr_Trigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, 100663378);
			TriggeredBlockingAnimation.NativeMethodInfoPtr_TriggerAndBlock_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, 100663379);
			TriggeredBlockingAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, 100663380);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00004E78 File Offset: 0x00003078
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00004EB8 File Offset: 0x000030B8
		public unsafe Animator Animator
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation.NativeMethodInfoPtr_get_Animator_Public_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation.NativeMethodInfoPtr_set_Animator_Private_set_Void_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00004EFC File Offset: 0x000030FC
		public unsafe string TriggerName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation.NativeMethodInfoPtr_get_TriggerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004F34 File Offset: 0x00003134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263638, XrefRangeEnd = 1263643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004F68 File Offset: 0x00003168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1263648, RefRangeEnd = 1263649, XrefRangeStart = 1263643, XrefRangeEnd = 1263648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForAnimatorInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation.NativeMethodInfoPtr_WaitForAnimatorInitialized_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00004FA8 File Offset: 0x000031A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1263656, RefRangeEnd = 1263661, XrefRangeStart = 1263649, XrefRangeEnd = 1263656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation.NativeMethodInfoPtr_Trigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004FDC File Offset: 0x000031DC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1263666, RefRangeEnd = 1263676, XrefRangeStart = 1263661, XrefRangeEnd = 1263666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TriggerAndBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation.NativeMethodInfoPtr_TriggerAndBlock_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000501C File Offset: 0x0000321C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263676, XrefRangeEnd = 1263677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TriggeredBlockingAnimation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000025EE File Offset: 0x000007EE
		public TriggeredBlockingAnimation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00005058 File Offset: 0x00003258
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x000025F7 File Offset: 0x000007F7
		public unsafe float maxDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation.NativeFieldInfoPtr_maxDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation.NativeFieldInfoPtr_maxDuration)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00005080 File Offset: 0x00003280
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002612 File Offset: 0x00000812
		public unsafe Animator _Animator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation.NativeFieldInfoPtr__Animator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation.NativeFieldInfoPtr__Animator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000050B0 File Offset: 0x000032B0
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002631 File Offset: 0x00000831
		public unsafe string triggerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation.NativeFieldInfoPtr_triggerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation.NativeFieldInfoPtr_triggerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000050D8 File Offset: 0x000032D8
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00002650 File Offset: 0x00000850
		public unsafe bool debugLogWhileBlocking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation.NativeFieldInfoPtr_debugLogWhileBlocking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation.NativeFieldInfoPtr_debugLogWhileBlocking)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00005100 File Offset: 0x00003300
		// (set) Token: 0x060000CA RID: 202 RVA: 0x0000266B File Offset: 0x0000086B
		public unsafe int parameterHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation.NativeFieldInfoPtr_parameterHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation.NativeFieldInfoPtr_parameterHash)) = value;
			}
		}

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_maxDuration;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr__Animator_k__BackingField;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_triggerName;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_debugLogWhileBlocking;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_parameterHash;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_Animator_Public_get_Animator_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_set_Animator_Private_set_Void_Animator_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_TriggerName_Public_get_String_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_WaitForAnimatorInitialized_Public_IEnumerator_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Void_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_TriggerAndBlock_Public_IEnumerator_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200001A RID: 26
		[ObfuscatedName("dwd.core.animation.TriggeredBlockingAnimation+<TriggerAndBlock>d__13")]
		public sealed class _TriggerAndBlock_d__13 : global::Il2CppSystem.Object
		{
			// Token: 0x0600011F RID: 287 RVA: 0x00005EEC File Offset: 0x000040EC
			// Note: this type is marked as 'beforefieldinit'.
			static _TriggerAndBlock_d__13()
			{
				Il2CppClassPointerStore<TriggeredBlockingAnimation._TriggerAndBlock_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, "<TriggerAndBlock>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggeredBlockingAnimation._TriggerAndBlock_d__13>.NativeClassPtr);
				TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredBlockingAnimation._TriggerAndBlock_d__13>.NativeClassPtr, "<>1__state");
				TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredBlockingAnimation._TriggerAndBlock_d__13>.NativeClassPtr, "<>2__current");
				TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredBlockingAnimation._TriggerAndBlock_d__13>.NativeClassPtr, "<>4__this");
				TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeFieldInfoPtr__currentTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredBlockingAnimation._TriggerAndBlock_d__13>.NativeClassPtr, "<currentTime>5__2");
				TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation._TriggerAndBlock_d__13>.NativeClassPtr, 100663381);
				TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation._TriggerAndBlock_d__13>.NativeClassPtr, 100663382);
				TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation._TriggerAndBlock_d__13>.NativeClassPtr, 100663383);
				TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation._TriggerAndBlock_d__13>.NativeClassPtr, 100663384);
				TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation._TriggerAndBlock_d__13>.NativeClassPtr, 100663385);
				TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation._TriggerAndBlock_d__13>.NativeClassPtr, 100663386);
			}

			// Token: 0x06000120 RID: 288 RVA: 0x00005FE0 File Offset: 0x000041E0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TriggerAndBlock_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggeredBlockingAnimation._TriggerAndBlock_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000121 RID: 289 RVA: 0x00006028 File Offset: 0x00004228
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000122 RID: 290 RVA: 0x0000605C File Offset: 0x0000425C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263606, XrefRangeEnd = 1263626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000123 RID: 291 RVA: 0x00006098 File Offset: 0x00004298
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000124 RID: 292 RVA: 0x000060D8 File Offset: 0x000042D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263626, XrefRangeEnd = 1263631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000125 RID: 293 RVA: 0x0000610C File Offset: 0x0000430C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000126 RID: 294 RVA: 0x0000296D File Offset: 0x00000B6D
			public _TriggerAndBlock_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000127 RID: 295 RVA: 0x0000614C File Offset: 0x0000434C
			// (set) Token: 0x06000128 RID: 296 RVA: 0x00002976 File Offset: 0x00000B76
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000129 RID: 297 RVA: 0x00006174 File Offset: 0x00004374
			// (set) Token: 0x0600012A RID: 298 RVA: 0x00002991 File Offset: 0x00000B91
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x0600012B RID: 299 RVA: 0x000061A4 File Offset: 0x000043A4
			// (set) Token: 0x0600012C RID: 300 RVA: 0x000029B0 File Offset: 0x00000BB0
			public unsafe TriggeredBlockingAnimation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x0600012D RID: 301 RVA: 0x000061D4 File Offset: 0x000043D4
			// (set) Token: 0x0600012E RID: 302 RVA: 0x000029CF File Offset: 0x00000BCF
			public unsafe float _currentTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeFieldInfoPtr__currentTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._TriggerAndBlock_d__13.NativeFieldInfoPtr__currentTime_5__2)) = value;
				}
			}

			// Token: 0x040000A6 RID: 166
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000A7 RID: 167
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000A8 RID: 168
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000A9 RID: 169
			private static readonly IntPtr NativeFieldInfoPtr__currentTime_5__2;

			// Token: 0x040000AA RID: 170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000AB RID: 171
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000AC RID: 172
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000AD RID: 173
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000AE RID: 174
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000AF RID: 175
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200001B RID: 27
		[ObfuscatedName("dwd.core.animation.TriggeredBlockingAnimation+<WaitForAnimatorInitialized>d__11")]
		public sealed class _WaitForAnimatorInitialized_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x0600012F RID: 303 RVA: 0x000061FC File Offset: 0x000043FC
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForAnimatorInitialized_d__11()
			{
				Il2CppClassPointerStore<TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggeredBlockingAnimation>.NativeClassPtr, "<WaitForAnimatorInitialized>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11>.NativeClassPtr);
				TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11>.NativeClassPtr, "<>1__state");
				TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11>.NativeClassPtr, "<>2__current");
				TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11>.NativeClassPtr, "<>4__this");
				TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11>.NativeClassPtr, 100663387);
				TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11>.NativeClassPtr, 100663388);
				TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11>.NativeClassPtr, 100663389);
				TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11>.NativeClassPtr, 100663390);
				TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11>.NativeClassPtr, 100663391);
				TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11>.NativeClassPtr, 100663392);
			}

			// Token: 0x06000130 RID: 304 RVA: 0x000062DC File Offset: 0x000044DC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForAnimatorInitialized_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000131 RID: 305 RVA: 0x00006324 File Offset: 0x00004524
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000132 RID: 306 RVA: 0x00006358 File Offset: 0x00004558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263631, XrefRangeEnd = 1263633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000133 RID: 307 RVA: 0x00006394 File Offset: 0x00004594
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000134 RID: 308 RVA: 0x000063D4 File Offset: 0x000045D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263633, XrefRangeEnd = 1263638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000135 RID: 309 RVA: 0x00006408 File Offset: 0x00004608
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000136 RID: 310 RVA: 0x000029EA File Offset: 0x00000BEA
			public _WaitForAnimatorInitialized_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000137 RID: 311 RVA: 0x00006448 File Offset: 0x00004648
			// (set) Token: 0x06000138 RID: 312 RVA: 0x000029F3 File Offset: 0x00000BF3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000139 RID: 313 RVA: 0x00006470 File Offset: 0x00004670
			// (set) Token: 0x0600013A RID: 314 RVA: 0x00002A0E File Offset: 0x00000C0E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x0600013B RID: 315 RVA: 0x000064A0 File Offset: 0x000046A0
			// (set) Token: 0x0600013C RID: 316 RVA: 0x00002A2D File Offset: 0x00000C2D
			public unsafe TriggeredBlockingAnimation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggeredBlockingAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggeredBlockingAnimation._WaitForAnimatorInitialized_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000B0 RID: 176
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000B1 RID: 177
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000B2 RID: 178
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000B3 RID: 179
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000B4 RID: 180
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000B5 RID: 181
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000B6 RID: 182
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000B7 RID: 183
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000B8 RID: 184
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
