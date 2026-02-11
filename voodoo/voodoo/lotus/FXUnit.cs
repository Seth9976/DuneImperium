using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000057 RID: 87
	public class FXUnit : MonoBehaviour
	{
		// Token: 0x06000538 RID: 1336 RVA: 0x0001A85C File Offset: 0x00018A5C
		// Note: this type is marked as 'beforefieldinit'.
		static FXUnit()
		{
			Il2CppClassPointerStore<FXUnit>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "FXUnit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXUnit>.NativeClassPtr);
			FXUnit.NativeFieldInfoPtr_despawnAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, "despawnAfter");
			FXUnit.NativeFieldInfoPtr_poolable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, "poolable");
			FXUnit.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, "position");
			FXUnit.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, "anim");
			FXUnit.NativeFieldInfoPtr_OnAnimationSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, "OnAnimationSignal");
			FXUnit.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, 100663950);
			FXUnit.NativeMethodInfoPtr_Detach_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, 100663951);
			FXUnit.NativeMethodInfoPtr_FXDespawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, 100663952);
			FXUnit.NativeMethodInfoPtr_TransitionOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, 100663953);
			FXUnit.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, 100663954);
			FXUnit.NativeMethodInfoPtr_DespawnAfter_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, 100663955);
			FXUnit.NativeMethodInfoPtr_despawnAfterRoutine_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, 100663956);
			FXUnit.NativeMethodInfoPtr_AnimationSignal_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, 100663957);
			FXUnit.NativeMethodInfoPtr_WaitForSignal_Public_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, 100663958);
			FXUnit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, 100663959);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0001A9B8 File Offset: 0x00018BB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1111504, RefRangeEnd = 1111506, XrefRangeStart = 1111483, XrefRangeEnd = 1111504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0001A9EC File Offset: 0x00018BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111506, XrefRangeEnd = 1111509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Detach()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit.NativeMethodInfoPtr_Detach_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0001AA20 File Offset: 0x00018C20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1111523, RefRangeEnd = 1111525, XrefRangeStart = 1111509, XrefRangeEnd = 1111523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FXDespawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit.NativeMethodInfoPtr_FXDespawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0001AA54 File Offset: 0x00018C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111525, XrefRangeEnd = 1111529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransitionOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit.NativeMethodInfoPtr_TransitionOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0001AA88 File Offset: 0x00018C88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1111531, RefRangeEnd = 1111532, XrefRangeStart = 1111529, XrefRangeEnd = 1111531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBool(string key, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit.NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0001AAD8 File Offset: 0x00018CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111532, XrefRangeEnd = 1111542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DespawnAfter(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit.NativeMethodInfoPtr_DespawnAfter_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0001AB18 File Offset: 0x00018D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111542, XrefRangeEnd = 1111547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator despawnAfterRoutine(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit.NativeMethodInfoPtr_despawnAfterRoutine_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0001AB64 File Offset: 0x00018D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111547, XrefRangeEnd = 1111551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AnimationSignal(string signal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(signal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit.NativeMethodInfoPtr_AnimationSignal_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0001ABA8 File Offset: 0x00018DA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1111557, RefRangeEnd = 1111559, XrefRangeStart = 1111551, XrefRangeEnd = 1111557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForSignal(string signal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(signal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit.NativeMethodInfoPtr_WaitForSignal_Public_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0001ABF8 File Offset: 0x00018DF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1111567, RefRangeEnd = 1111568, XrefRangeStart = 1111559, XrefRangeEnd = 1111567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXUnit()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXUnit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00004941 File Offset: 0x00002B41
		public FXUnit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x0001AC34 File Offset: 0x00018E34
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x0000494A File Offset: 0x00002B4A
		public unsafe float despawnAfter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit.NativeFieldInfoPtr_despawnAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit.NativeFieldInfoPtr_despawnAfter)) = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0001AC5C File Offset: 0x00018E5C
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x00004965 File Offset: 0x00002B65
		public unsafe PoolableItem poolable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit.NativeFieldInfoPtr_poolable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit.NativeFieldInfoPtr_poolable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x0001AC8C File Offset: 0x00018E8C
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00004984 File Offset: 0x00002B84
		public unsafe FXUnit.FXPosition position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x0001ACB4 File Offset: 0x00018EB4
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x0000499F File Offset: 0x00002B9F
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0001ACE4 File Offset: 0x00018EE4
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x000049BE File Offset: 0x00002BBE
		public unsafe AnimationSignalEvent OnAnimationSignal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit.NativeFieldInfoPtr_OnAnimationSignal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationSignalEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit.NativeFieldInfoPtr_OnAnimationSignal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeFieldInfoPtr_despawnAfter;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeFieldInfoPtr_poolable;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeFieldInfoPtr_OnAnimationSignal;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_Detach_Public_Void_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_FXDespawn_Public_Void_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_TransitionOut_Public_Void_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_SetBool_Public_Void_String_Boolean_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_DespawnAfter_Private_Void_Single_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_despawnAfterRoutine_Private_IEnumerator_Single_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_AnimationSignal_Public_Void_String_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_WaitForSignal_Public_IEnumerator_String_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000D8 RID: 216
		public enum FXPosition
		{
			// Token: 0x04000712 RID: 1810
			Local,
			// Token: 0x04000713 RID: 1811
			Global,
			// Token: 0x04000714 RID: 1812
			GlobalIndependent
		}

		// Token: 0x020000D9 RID: 217
		[ObfuscatedName("lotus.FXUnit+<WaitForSignal>d__14")]
		public sealed class _WaitForSignal_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x06000B57 RID: 2903 RVA: 0x0002E6D0 File Offset: 0x0002C8D0
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForSignal_d__14()
			{
				Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, "<WaitForSignal>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr);
				FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr, "<>1__state");
				FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr, "<>2__current");
				FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr_signal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr, "signal");
				FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr, "<>4__this");
				FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr__asd_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr, "<asd>5__2");
				FXUnit._WaitForSignal_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr, 100663960);
				FXUnit._WaitForSignal_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr, 100663961);
				FXUnit._WaitForSignal_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr, 100663962);
				FXUnit._WaitForSignal_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr, 100663963);
				FXUnit._WaitForSignal_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr, 100663964);
				FXUnit._WaitForSignal_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr, 100663965);
			}

			// Token: 0x06000B58 RID: 2904 RVA: 0x0002E7D8 File Offset: 0x0002C9D8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForSignal_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXUnit._WaitForSignal_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit._WaitForSignal_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000B59 RID: 2905 RVA: 0x0002E820 File Offset: 0x0002CA20
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit._WaitForSignal_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B5A RID: 2906 RVA: 0x0002E854 File Offset: 0x0002CA54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111442, XrefRangeEnd = 1111467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit._WaitForSignal_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000352 RID: 850
			// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0002E890 File Offset: 0x0002CA90
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit._WaitForSignal_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B5C RID: 2908 RVA: 0x0002E8D0 File Offset: 0x0002CAD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111467, XrefRangeEnd = 1111472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit._WaitForSignal_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000353 RID: 851
			// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0002E904 File Offset: 0x0002CB04
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit._WaitForSignal_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B5E RID: 2910 RVA: 0x0000791E File Offset: 0x00005B1E
			public _WaitForSignal_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700034D RID: 845
			// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0002E944 File Offset: 0x0002CB44
			// (set) Token: 0x06000B60 RID: 2912 RVA: 0x00007927 File Offset: 0x00005B27
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700034E RID: 846
			// (get) Token: 0x06000B61 RID: 2913 RVA: 0x0002E96C File Offset: 0x0002CB6C
			// (set) Token: 0x06000B62 RID: 2914 RVA: 0x00007942 File Offset: 0x00005B42
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700034F RID: 847
			// (get) Token: 0x06000B63 RID: 2915 RVA: 0x0002E99C File Offset: 0x0002CB9C
			// (set) Token: 0x06000B64 RID: 2916 RVA: 0x00007961 File Offset: 0x00005B61
			public unsafe string signal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr_signal);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr_signal), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000350 RID: 848
			// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0002E9C4 File Offset: 0x0002CBC4
			// (set) Token: 0x06000B66 RID: 2918 RVA: 0x00007980 File Offset: 0x00005B80
			public unsafe FXUnit __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000351 RID: 849
			// (get) Token: 0x06000B67 RID: 2919 RVA: 0x0002E9F4 File Offset: 0x0002CBF4
			// (set) Token: 0x06000B68 RID: 2920 RVA: 0x0000799F File Offset: 0x00005B9F
			public unsafe AnimationSignalDelegate _asd_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr__asd_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationSignalDelegate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._WaitForSignal_d__14.NativeFieldInfoPtr__asd_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000715 RID: 1813
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000716 RID: 1814
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000717 RID: 1815
			private static readonly IntPtr NativeFieldInfoPtr_signal;

			// Token: 0x04000718 RID: 1816
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000719 RID: 1817
			private static readonly IntPtr NativeFieldInfoPtr__asd_5__2;

			// Token: 0x0400071A RID: 1818
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400071B RID: 1819
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400071C RID: 1820
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400071D RID: 1821
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400071E RID: 1822
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400071F RID: 1823
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000DA RID: 218
		[ObfuscatedName("lotus.FXUnit+<despawnAfterRoutine>d__12")]
		public sealed class _despawnAfterRoutine_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x06000B69 RID: 2921 RVA: 0x0002EA24 File Offset: 0x0002CC24
			// Note: this type is marked as 'beforefieldinit'.
			static _despawnAfterRoutine_d__12()
			{
				Il2CppClassPointerStore<FXUnit._despawnAfterRoutine_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXUnit>.NativeClassPtr, "<despawnAfterRoutine>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXUnit._despawnAfterRoutine_d__12>.NativeClassPtr);
				FXUnit._despawnAfterRoutine_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit._despawnAfterRoutine_d__12>.NativeClassPtr, "<>1__state");
				FXUnit._despawnAfterRoutine_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit._despawnAfterRoutine_d__12>.NativeClassPtr, "<>2__current");
				FXUnit._despawnAfterRoutine_d__12.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit._despawnAfterRoutine_d__12>.NativeClassPtr, "time");
				FXUnit._despawnAfterRoutine_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnit._despawnAfterRoutine_d__12>.NativeClassPtr, "<>4__this");
				FXUnit._despawnAfterRoutine_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit._despawnAfterRoutine_d__12>.NativeClassPtr, 100663966);
				FXUnit._despawnAfterRoutine_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit._despawnAfterRoutine_d__12>.NativeClassPtr, 100663967);
				FXUnit._despawnAfterRoutine_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit._despawnAfterRoutine_d__12>.NativeClassPtr, 100663968);
				FXUnit._despawnAfterRoutine_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit._despawnAfterRoutine_d__12>.NativeClassPtr, 100663969);
				FXUnit._despawnAfterRoutine_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit._despawnAfterRoutine_d__12>.NativeClassPtr, 100663970);
				FXUnit._despawnAfterRoutine_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnit._despawnAfterRoutine_d__12>.NativeClassPtr, 100663971);
			}

			// Token: 0x06000B6A RID: 2922 RVA: 0x0002EB18 File Offset: 0x0002CD18
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _despawnAfterRoutine_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXUnit._despawnAfterRoutine_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit._despawnAfterRoutine_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000B6B RID: 2923 RVA: 0x0002EB60 File Offset: 0x0002CD60
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit._despawnAfterRoutine_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B6C RID: 2924 RVA: 0x0002EB94 File Offset: 0x0002CD94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111472, XrefRangeEnd = 1111478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit._despawnAfterRoutine_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000358 RID: 856
			// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0002EBD0 File Offset: 0x0002CDD0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit._despawnAfterRoutine_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B6E RID: 2926 RVA: 0x0002EC10 File Offset: 0x0002CE10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111478, XrefRangeEnd = 1111483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit._despawnAfterRoutine_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000359 RID: 857
			// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0002EC44 File Offset: 0x0002CE44
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnit._despawnAfterRoutine_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000B70 RID: 2928 RVA: 0x000079BE File Offset: 0x00005BBE
			public _despawnAfterRoutine_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000354 RID: 852
			// (get) Token: 0x06000B71 RID: 2929 RVA: 0x0002EC84 File Offset: 0x0002CE84
			// (set) Token: 0x06000B72 RID: 2930 RVA: 0x000079C7 File Offset: 0x00005BC7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._despawnAfterRoutine_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._despawnAfterRoutine_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000355 RID: 853
			// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0002ECAC File Offset: 0x0002CEAC
			// (set) Token: 0x06000B74 RID: 2932 RVA: 0x000079E2 File Offset: 0x00005BE2
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._despawnAfterRoutine_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._despawnAfterRoutine_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000356 RID: 854
			// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0002ECDC File Offset: 0x0002CEDC
			// (set) Token: 0x06000B76 RID: 2934 RVA: 0x00007A01 File Offset: 0x00005C01
			public unsafe float time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._despawnAfterRoutine_d__12.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._despawnAfterRoutine_d__12.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x17000357 RID: 855
			// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0002ED04 File Offset: 0x0002CF04
			// (set) Token: 0x06000B78 RID: 2936 RVA: 0x00007A1C File Offset: 0x00005C1C
			public unsafe FXUnit __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._despawnAfterRoutine_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnit._despawnAfterRoutine_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000720 RID: 1824
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000721 RID: 1825
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000722 RID: 1826
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04000723 RID: 1827
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000724 RID: 1828
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000725 RID: 1829
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000726 RID: 1830
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000727 RID: 1831
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000728 RID: 1832
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000729 RID: 1833
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
