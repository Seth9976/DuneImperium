using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x02000005 RID: 5
	public class BoolBlockingAnimation : BlockingAnimation
	{
		// Token: 0x06000017 RID: 23 RVA: 0x0000302C File Offset: 0x0000122C
		// Note: this type is marked as 'beforefieldinit'.
		static BoolBlockingAnimation()
		{
			Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "BoolBlockingAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr);
			BoolBlockingAnimation.NativeFieldInfoPtr_maxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, "maxDuration");
			BoolBlockingAnimation.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, "animator");
			BoolBlockingAnimation.NativeFieldInfoPtr_boolName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, "boolName");
			BoolBlockingAnimation.NativeFieldInfoPtr_debugLogWhileBlocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, "debugLogWhileBlocking");
			BoolBlockingAnimation.NativeFieldInfoPtr_parameterHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, "parameterHash");
			BoolBlockingAnimation.NativeFieldInfoPtr_delayedSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, "delayedSet");
			BoolBlockingAnimation.NativeMethodInfoPtr_get_Animator_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, 100663309);
			BoolBlockingAnimation.NativeMethodInfoPtr_set_Animator_Private_set_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, 100663310);
			BoolBlockingAnimation.NativeMethodInfoPtr_get_BoolName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, 100663311);
			BoolBlockingAnimation.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, 100663312);
			BoolBlockingAnimation.NativeMethodInfoPtr_SetOn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, 100663313);
			BoolBlockingAnimation.NativeMethodInfoPtr_SetOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, 100663314);
			BoolBlockingAnimation.NativeMethodInfoPtr_SetBool_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, 100663315);
			BoolBlockingAnimation.NativeMethodInfoPtr_SetAndBlock_Public_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, 100663316);
			BoolBlockingAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, 100663317);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00003188 File Offset: 0x00001388
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000031C8 File Offset: 0x000013C8
		public unsafe Animator Animator
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation.NativeMethodInfoPtr_get_Animator_Public_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263158, XrefRangeEnd = 1263164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation.NativeMethodInfoPtr_set_Animator_Private_set_Void_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000320C File Offset: 0x0000140C
		public unsafe string BoolName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation.NativeMethodInfoPtr_get_BoolName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003244 File Offset: 0x00001444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263164, XrefRangeEnd = 1263174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003278 File Offset: 0x00001478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263174, XrefRangeEnd = 1263175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation.NativeMethodInfoPtr_SetOn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000032AC File Offset: 0x000014AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263175, XrefRangeEnd = 1263176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation.NativeMethodInfoPtr_SetOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000032E0 File Offset: 0x000014E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1263184, RefRangeEnd = 1263190, XrefRangeStart = 1263176, XrefRangeEnd = 1263184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref on;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation.NativeMethodInfoPtr_SetBool_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003320 File Offset: 0x00001520
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1263195, RefRangeEnd = 1263197, XrefRangeStart = 1263190, XrefRangeEnd = 1263195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SetAndBlock(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref on;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation.NativeMethodInfoPtr_SetAndBlock_Public_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000336C File Offset: 0x0000156C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263197, XrefRangeEnd = 1263202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolBlockingAnimation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020A5 File Offset: 0x000002A5
		public BoolBlockingAnimation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000033A8 File Offset: 0x000015A8
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000020AE File Offset: 0x000002AE
		public unsafe float maxDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation.NativeFieldInfoPtr_maxDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation.NativeFieldInfoPtr_maxDuration)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000033D0 File Offset: 0x000015D0
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000020C9 File Offset: 0x000002C9
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003400 File Offset: 0x00001600
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000020E8 File Offset: 0x000002E8
		public unsafe string boolName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation.NativeFieldInfoPtr_boolName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation.NativeFieldInfoPtr_boolName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003428 File Offset: 0x00001628
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002107 File Offset: 0x00000307
		public unsafe bool debugLogWhileBlocking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation.NativeFieldInfoPtr_debugLogWhileBlocking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation.NativeFieldInfoPtr_debugLogWhileBlocking)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003450 File Offset: 0x00001650
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002122 File Offset: 0x00000322
		public unsafe int parameterHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation.NativeFieldInfoPtr_parameterHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation.NativeFieldInfoPtr_parameterHash)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003478 File Offset: 0x00001678
		// (set) Token: 0x0600002D RID: 45 RVA: 0x0000213D File Offset: 0x0000033D
		public Nullable<bool> delayedSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation.NativeFieldInfoPtr_delayedSet);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation.NativeFieldInfoPtr_delayedSet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_maxDuration;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_boolName;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_debugLogWhileBlocking;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_parameterHash;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_delayedSet;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_Animator_Public_get_Animator_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_set_Animator_Private_set_Void_Animator_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_get_BoolName_Public_get_String_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_SetOn_Public_Void_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_SetOff_Public_Void_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Public_Void_Boolean_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_SetAndBlock_Public_IEnumerator_Boolean_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000018 RID: 24
		[ObfuscatedName("dwd.core.animation.BoolBlockingAnimation+<SetAndBlock>d__15")]
		public sealed class _SetAndBlock_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x060000FD RID: 253 RVA: 0x00005890 File Offset: 0x00003A90
			// Note: this type is marked as 'beforefieldinit'.
			static _SetAndBlock_d__15()
			{
				Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoolBlockingAnimation>.NativeClassPtr, "<SetAndBlock>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr);
				BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr, "<>1__state");
				BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr, "<>2__current");
				BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr, "on");
				BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr, "<>4__this");
				BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr__currentTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr, "<currentTime>5__2");
				BoolBlockingAnimation._SetAndBlock_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr, 100663318);
				BoolBlockingAnimation._SetAndBlock_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr, 100663319);
				BoolBlockingAnimation._SetAndBlock_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr, 100663320);
				BoolBlockingAnimation._SetAndBlock_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr, 100663321);
				BoolBlockingAnimation._SetAndBlock_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr, 100663322);
				BoolBlockingAnimation._SetAndBlock_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr, 100663323);
			}

			// Token: 0x060000FE RID: 254 RVA: 0x00005998 File Offset: 0x00003B98
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetAndBlock_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolBlockingAnimation._SetAndBlock_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation._SetAndBlock_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060000FF RID: 255 RVA: 0x000059E0 File Offset: 0x00003BE0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation._SetAndBlock_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000100 RID: 256 RVA: 0x00005A14 File Offset: 0x00003C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263136, XrefRangeEnd = 1263153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation._SetAndBlock_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000101 RID: 257 RVA: 0x00005A50 File Offset: 0x00003C50
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation._SetAndBlock_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000102 RID: 258 RVA: 0x00005A90 File Offset: 0x00003C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263153, XrefRangeEnd = 1263158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation._SetAndBlock_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000103 RID: 259 RVA: 0x00005AC4 File Offset: 0x00003CC4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolBlockingAnimation._SetAndBlock_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000104 RID: 260 RVA: 0x00002858 File Offset: 0x00000A58
			public _SetAndBlock_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000105 RID: 261 RVA: 0x00005B04 File Offset: 0x00003D04
			// (set) Token: 0x06000106 RID: 262 RVA: 0x00002861 File Offset: 0x00000A61
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x06000107 RID: 263 RVA: 0x00005B2C File Offset: 0x00003D2C
			// (set) Token: 0x06000108 RID: 264 RVA: 0x0000287C File Offset: 0x00000A7C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x06000109 RID: 265 RVA: 0x00005B5C File Offset: 0x00003D5C
			// (set) Token: 0x0600010A RID: 266 RVA: 0x0000289B File Offset: 0x00000A9B
			public unsafe bool on
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr_on);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr_on)) = value;
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x0600010B RID: 267 RVA: 0x00005B84 File Offset: 0x00003D84
			// (set) Token: 0x0600010C RID: 268 RVA: 0x000028B6 File Offset: 0x00000AB6
			public unsafe BoolBlockingAnimation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolBlockingAnimation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x0600010D RID: 269 RVA: 0x00005BB4 File Offset: 0x00003DB4
			// (set) Token: 0x0600010E RID: 270 RVA: 0x000028D5 File Offset: 0x00000AD5
			public unsafe float _currentTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr__currentTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolBlockingAnimation._SetAndBlock_d__15.NativeFieldInfoPtr__currentTime_5__2)) = value;
				}
			}

			// Token: 0x04000091 RID: 145
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000092 RID: 146
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000093 RID: 147
			private static readonly IntPtr NativeFieldInfoPtr_on;

			// Token: 0x04000094 RID: 148
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000095 RID: 149
			private static readonly IntPtr NativeFieldInfoPtr__currentTime_5__2;

			// Token: 0x04000096 RID: 150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000097 RID: 151
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000098 RID: 152
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000099 RID: 153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400009A RID: 154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400009B RID: 155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
