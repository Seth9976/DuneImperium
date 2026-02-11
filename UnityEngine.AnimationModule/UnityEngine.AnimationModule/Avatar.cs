using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001E RID: 30
	public class Avatar : Object
	{
		// Token: 0x0600023A RID: 570 RVA: 0x0000F1D4 File Offset: 0x0000D3D4
		// Note: this type is marked as 'beforefieldinit'.
		static Avatar()
		{
			Il2CppClassPointerStore<Avatar>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "Avatar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar>.NativeClassPtr);
			Avatar.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100663724);
			Avatar.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100663725);
			Avatar.NativeMethodInfoPtr_get_isHuman_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100663726);
			Avatar.SetMuscleMinMaxDelegateField = IL2CPP.ResolveICall<Avatar.SetMuscleMinMaxDelegate>("UnityEngine.Avatar::SetMuscleMinMax");
			Avatar.SetParameterDelegateField = IL2CPP.ResolveICall<Avatar.SetParameterDelegate>("UnityEngine.Avatar::SetParameter");
			Avatar.Internal_GetAxisLengthDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetAxisLengthDelegate>("UnityEngine.Avatar::Internal_GetAxisLength");
			Avatar.Internal_GetPreRotation_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetPreRotation_InjectedDelegate>("UnityEngine.Avatar::Internal_GetPreRotation_Injected");
			Avatar.Internal_GetPostRotation_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetPostRotation_InjectedDelegate>("UnityEngine.Avatar::Internal_GetPostRotation_Injected");
			Avatar.Internal_GetZYPostQ_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetZYPostQ_InjectedDelegate>("UnityEngine.Avatar::Internal_GetZYPostQ_Injected");
			Avatar.Internal_GetZYRoll_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetZYRoll_InjectedDelegate>("UnityEngine.Avatar::Internal_GetZYRoll_Injected");
			Avatar.Internal_GetLimitSign_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetLimitSign_InjectedDelegate>("UnityEngine.Avatar::Internal_GetLimitSign_Injected");
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220826, XrefRangeEnd = 1220830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Avatar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000F2F4 File Offset: 0x0000D4F4
		public unsafe bool isValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220830, XrefRangeEnd = 1220832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0000F330 File Offset: 0x0000D530
		public unsafe bool isHuman
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220832, XrefRangeEnd = 1220834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_isHuman_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002578 File Offset: 0x00000778
		public Avatar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002581 File Offset: 0x00000781
		public void SetMuscleMinMax(int muscleId, float min, float max)
		{
			Avatar.SetMuscleMinMaxDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), muscleId, min, max);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002596 File Offset: 0x00000796
		public void SetParameter(int parameterId, float value)
		{
			Avatar.SetParameterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), parameterId, value);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000F36C File Offset: 0x0000D56C
		public float GetAxisLength(int humanId)
		{
			return this.Internal_GetAxisLength(HumanTrait.GetBoneIndexFromMono(humanId));
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000F38C File Offset: 0x0000D58C
		public Quaternion GetPreRotation(int humanId)
		{
			return this.Internal_GetPreRotation(HumanTrait.GetBoneIndexFromMono(humanId));
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000F3AC File Offset: 0x0000D5AC
		public Quaternion GetPostRotation(int humanId)
		{
			return this.Internal_GetPostRotation(HumanTrait.GetBoneIndexFromMono(humanId));
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000F3CC File Offset: 0x0000D5CC
		public Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q)
		{
			return this.Internal_GetZYPostQ(HumanTrait.GetBoneIndexFromMono(humanId), parentQ, q);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000F3EC File Offset: 0x0000D5EC
		public Quaternion GetZYRoll(int humanId, Vector3 uvw)
		{
			return this.Internal_GetZYRoll(HumanTrait.GetBoneIndexFromMono(humanId), uvw);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000F40C File Offset: 0x0000D60C
		public Vector3 GetLimitSign(int humanId)
		{
			return this.Internal_GetLimitSign(HumanTrait.GetBoneIndexFromMono(humanId));
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000025AA File Offset: 0x000007AA
		public float Internal_GetAxisLength(int humanId)
		{
			return Avatar.Internal_GetAxisLengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000F42C File Offset: 0x0000D62C
		public Quaternion Internal_GetPreRotation(int humanId)
		{
			Quaternion quaternion;
			this.Internal_GetPreRotation_Injected(humanId, out quaternion);
			return quaternion;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000F444 File Offset: 0x0000D644
		public Quaternion Internal_GetPostRotation(int humanId)
		{
			Quaternion quaternion;
			this.Internal_GetPostRotation_Injected(humanId, out quaternion);
			return quaternion;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000F45C File Offset: 0x0000D65C
		public Quaternion Internal_GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q)
		{
			Quaternion quaternion;
			this.Internal_GetZYPostQ_Injected(humanId, ref parentQ, ref q, out quaternion);
			return quaternion;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000F478 File Offset: 0x0000D678
		public Quaternion Internal_GetZYRoll(int humanId, Vector3 uvw)
		{
			Quaternion quaternion;
			this.Internal_GetZYRoll_Injected(humanId, ref uvw, out quaternion);
			return quaternion;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000F494 File Offset: 0x0000D694
		public Vector3 Internal_GetLimitSign(int humanId)
		{
			Vector3 vector;
			this.Internal_GetLimitSign_Injected(humanId, out vector);
			return vector;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000025BD File Offset: 0x000007BD
		public void Internal_GetPreRotation_Injected(int humanId, out Quaternion ret)
		{
			Avatar.Internal_GetPreRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, out ret);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000025D1 File Offset: 0x000007D1
		public void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret)
		{
			Avatar.Internal_GetPostRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, out ret);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000025E5 File Offset: 0x000007E5
		public void Internal_GetZYPostQ_Injected(int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion ret)
		{
			Avatar.Internal_GetZYPostQ_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, ref parentQ, ref q, out ret);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000025FC File Offset: 0x000007FC
		public void Internal_GetZYRoll_Injected(int humanId, ref Vector3 uvw, out Quaternion ret)
		{
			Avatar.Internal_GetZYRoll_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, ref uvw, out ret);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002611 File Offset: 0x00000811
		public void Internal_GetLimitSign_Injected(int humanId, out Vector3 ret)
		{
			Avatar.Internal_GetLimitSign_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, out ret);
		}

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_get_isHuman_Public_get_Boolean_0;

		// Token: 0x04000271 RID: 625
		private static readonly Avatar.SetMuscleMinMaxDelegate SetMuscleMinMaxDelegateField;

		// Token: 0x04000272 RID: 626
		private static readonly Avatar.SetParameterDelegate SetParameterDelegateField;

		// Token: 0x04000273 RID: 627
		private static readonly Avatar.Internal_GetAxisLengthDelegate Internal_GetAxisLengthDelegateField;

		// Token: 0x04000274 RID: 628
		private static readonly Avatar.Internal_GetPreRotation_InjectedDelegate Internal_GetPreRotation_InjectedDelegateField;

		// Token: 0x04000275 RID: 629
		private static readonly Avatar.Internal_GetPostRotation_InjectedDelegate Internal_GetPostRotation_InjectedDelegateField;

		// Token: 0x04000276 RID: 630
		private static readonly Avatar.Internal_GetZYPostQ_InjectedDelegate Internal_GetZYPostQ_InjectedDelegateField;

		// Token: 0x04000277 RID: 631
		private static readonly Avatar.Internal_GetZYRoll_InjectedDelegate Internal_GetZYRoll_InjectedDelegateField;

		// Token: 0x04000278 RID: 632
		private static readonly Avatar.Internal_GetLimitSign_InjectedDelegate Internal_GetLimitSign_InjectedDelegateField;

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060005D7 RID: 1495
		private delegate void SetMuscleMinMaxDelegate(IntPtr @this, int muscleId, float min, float max);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060005D9 RID: 1497
		private delegate void SetParameterDelegate(IntPtr @this, int parameterId, float value);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060005DB RID: 1499
		private delegate float Internal_GetAxisLengthDelegate(IntPtr @this, int humanId);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060005DD RID: 1501
		private delegate void Internal_GetPreRotation_InjectedDelegate(IntPtr @this, int humanId, [Out] IntPtr ret);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060005DF RID: 1503
		private delegate void Internal_GetPostRotation_InjectedDelegate(IntPtr @this, int humanId, [Out] IntPtr ret);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060005E1 RID: 1505
		private delegate void Internal_GetZYPostQ_InjectedDelegate(IntPtr @this, int humanId, IntPtr parentQ, IntPtr q, [Out] IntPtr ret);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060005E3 RID: 1507
		private delegate void Internal_GetZYRoll_InjectedDelegate(IntPtr @this, int humanId, IntPtr uvw, [Out] IntPtr ret);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060005E5 RID: 1509
		private delegate void Internal_GetLimitSign_InjectedDelegate(IntPtr @this, int humanId, [Out] IntPtr ret);
	}
}
