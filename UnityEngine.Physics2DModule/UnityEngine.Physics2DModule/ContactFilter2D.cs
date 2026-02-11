using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	[StructLayout(2)]
	public struct ContactFilter2D
	{
		// Token: 0x060001DB RID: 475 RVA: 0x00009454 File Offset: 0x00007654
		// Note: this type is marked as 'beforefieldinit'.
		static ContactFilter2D()
		{
			Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "ContactFilter2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr);
			ContactFilter2D.NativeFieldInfoPtr_useTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useTriggers");
			ContactFilter2D.NativeFieldInfoPtr_useLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useLayerMask");
			ContactFilter2D.NativeFieldInfoPtr_useDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useDepth");
			ContactFilter2D.NativeFieldInfoPtr_useOutsideDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useOutsideDepth");
			ContactFilter2D.NativeFieldInfoPtr_useNormalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useNormalAngle");
			ContactFilter2D.NativeFieldInfoPtr_useOutsideNormalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "useOutsideNormalAngle");
			ContactFilter2D.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "layerMask");
			ContactFilter2D.NativeFieldInfoPtr_minDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "minDepth");
			ContactFilter2D.NativeFieldInfoPtr_maxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "maxDepth");
			ContactFilter2D.NativeFieldInfoPtr_minNormalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "minNormalAngle");
			ContactFilter2D.NativeFieldInfoPtr_maxNormalAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, "maxNormalAngle");
			ContactFilter2D.NativeMethodInfoPtr_CheckConsistency_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663333);
			ContactFilter2D.NativeMethodInfoPtr_SetLayerMask_Public_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663334);
			ContactFilter2D.NativeMethodInfoPtr_SetDepth_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663335);
			ContactFilter2D.NativeMethodInfoPtr_CreateLegacyFilter_Internal_Static_ContactFilter2D_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663336);
			ContactFilter2D.NativeMethodInfoPtr_CheckConsistency_Injected_Private_Static_Void_byref_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, 100663337);
			ContactFilter2D.IsFilteringNormalAngle_InjectedDelegateField = IL2CPP.ResolveICall<ContactFilter2D.IsFilteringNormalAngle_InjectedDelegate>("UnityEngine.ContactFilter2D::IsFilteringNormalAngle_Injected");
			ContactFilter2D.IsFilteringNormalAngleUsingAngle_InjectedDelegateField = IL2CPP.ResolveICall<ContactFilter2D.IsFilteringNormalAngleUsingAngle_InjectedDelegate>("UnityEngine.ContactFilter2D::IsFilteringNormalAngleUsingAngle_Injected");
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000095E4 File Offset: 0x000077E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268388, XrefRangeEnd = 1268390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckConsistency()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactFilter2D.NativeMethodInfoPtr_CheckConsistency_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000960C File Offset: 0x0000780C
		[CallerCount(0)]
		public unsafe void SetLayerMask(LayerMask layerMask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerMask;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactFilter2D.NativeMethodInfoPtr_SetLayerMask_Public_Void_LayerMask_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00009640 File Offset: 0x00007840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1268390, XrefRangeEnd = 1268392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDepth(float minDepth, float maxDepth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactFilter2D.NativeMethodInfoPtr_SetDepth_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00009680 File Offset: 0x00007880
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1268400, RefRangeEnd = 1268405, XrefRangeStart = 1268392, XrefRangeEnd = 1268400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref layerMask;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDepth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactFilter2D.NativeMethodInfoPtr_CreateLegacyFilter_Internal_Static_ContactFilter2D_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000096DC File Offset: 0x000078DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckConsistency_Injected(ref ContactFilter2D _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactFilter2D.NativeMethodInfoPtr_CheckConsistency_Injected_Private_Static_Void_byref_ContactFilter2D_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000299D File Offset: 0x00000B9D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactFilter2D>.NativeClassPtr, ref this));
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00009710 File Offset: 0x00007910
		public ContactFilter2D NoFilter()
		{
			this.useTriggers = true;
			this.useLayerMask = false;
			this.layerMask = -1;
			this.useDepth = false;
			this.useOutsideDepth = false;
			this.minDepth = float.NegativeInfinity;
			this.maxDepth = float.PositiveInfinity;
			this.useNormalAngle = false;
			this.useOutsideNormalAngle = false;
			this.minNormalAngle = 0f;
			this.maxNormalAngle = 359.9999f;
			return this;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000029AF File Offset: 0x00000BAF
		public void ClearLayerMask()
		{
			this.useLayerMask = false;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000029B9 File Offset: 0x00000BB9
		public void ClearDepth()
		{
			this.useDepth = false;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000029C3 File Offset: 0x00000BC3
		public void ClearNormalAngle()
		{
			this.useNormalAngle = false;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000029CD File Offset: 0x00000BCD
		public void SetNormalAngle(float minNormalAngle, float maxNormalAngle)
		{
			this.minNormalAngle = minNormalAngle;
			this.maxNormalAngle = maxNormalAngle;
			this.useNormalAngle = true;
			this.CheckConsistency();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000978C File Offset: 0x0000798C
		public bool isFiltering
		{
			get
			{
				return !this.useTriggers || this.useLayerMask || this.useDepth || this.useNormalAngle;
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000097C0 File Offset: 0x000079C0
		public bool IsFilteringTrigger(Collider2D collider)
		{
			return !this.useTriggers && collider.isTrigger;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000097E4 File Offset: 0x000079E4
		public bool IsFilteringLayerMask(GameObject obj)
		{
			return this.useLayerMask && (this.layerMask & (1 << obj.layer)) == 0;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000981C File Offset: 0x00007A1C
		public bool IsFilteringDepth(GameObject obj)
		{
			bool flag = !this.useDepth;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = this.minDepth > this.maxDepth;
				if (flag3)
				{
					float num = this.minDepth;
					this.minDepth = this.maxDepth;
					this.maxDepth = num;
				}
				float z = obj.transform.position.z;
				bool flag4 = z < this.minDepth || z > this.maxDepth;
				bool flag5 = this.useOutsideDepth;
				if (flag5)
				{
					flag2 = !flag4;
				}
				else
				{
					flag2 = flag4;
				}
			}
			return flag2;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000029EC File Offset: 0x00000BEC
		public bool IsFilteringNormalAngle(Vector2 normal)
		{
			return ContactFilter2D.IsFilteringNormalAngle_Injected(ref this, ref normal);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000098AC File Offset: 0x00007AAC
		public bool IsFilteringNormalAngle(float angle)
		{
			return this.IsFilteringNormalAngleUsingAngle(angle);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000029F6 File Offset: 0x00000BF6
		public bool IsFilteringNormalAngleUsingAngle(float angle)
		{
			return ContactFilter2D.IsFilteringNormalAngleUsingAngle_Injected(ref this, angle);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000029FF File Offset: 0x00000BFF
		public static bool IsFilteringNormalAngle_Injected(ref ContactFilter2D _unity_self, ref Vector2 normal)
		{
			return ContactFilter2D.IsFilteringNormalAngle_InjectedDelegateField(ref _unity_self, ref normal);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002A0D File Offset: 0x00000C0D
		public static bool IsFilteringNormalAngleUsingAngle_Injected(ref ContactFilter2D _unity_self, float angle)
		{
			return ContactFilter2D.IsFilteringNormalAngleUsingAngle_InjectedDelegateField(ref _unity_self, angle);
		}

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_useTriggers;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_useLayerMask;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_useDepth;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_useOutsideDepth;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_useNormalAngle;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_useOutsideNormalAngle;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_layerMask;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_minDepth;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_maxDepth;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_minNormalAngle;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_maxNormalAngle;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_CheckConsistency_Private_Void_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerMask_Public_Void_LayerMask_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_SetDepth_Public_Void_Single_Single_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_CreateLegacyFilter_Internal_Static_ContactFilter2D_Int32_Single_Single_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_CheckConsistency_Injected_Private_Static_Void_byref_ContactFilter2D_0;

		// Token: 0x040000A1 RID: 161
		[FieldOffset(0)]
		[MarshalAs(4)]
		public bool useTriggers;

		// Token: 0x040000A2 RID: 162
		[FieldOffset(1)]
		[MarshalAs(4)]
		public bool useLayerMask;

		// Token: 0x040000A3 RID: 163
		[FieldOffset(2)]
		[MarshalAs(4)]
		public bool useDepth;

		// Token: 0x040000A4 RID: 164
		[FieldOffset(3)]
		[MarshalAs(4)]
		public bool useOutsideDepth;

		// Token: 0x040000A5 RID: 165
		[FieldOffset(4)]
		[MarshalAs(4)]
		public bool useNormalAngle;

		// Token: 0x040000A6 RID: 166
		[FieldOffset(5)]
		[MarshalAs(4)]
		public bool useOutsideNormalAngle;

		// Token: 0x040000A7 RID: 167
		[FieldOffset(8)]
		public LayerMask layerMask;

		// Token: 0x040000A8 RID: 168
		[FieldOffset(12)]
		public float minDepth;

		// Token: 0x040000A9 RID: 169
		[FieldOffset(16)]
		public float maxDepth;

		// Token: 0x040000AA RID: 170
		[FieldOffset(20)]
		public float minNormalAngle;

		// Token: 0x040000AB RID: 171
		[FieldOffset(24)]
		public float maxNormalAngle;

		// Token: 0x040000AC RID: 172
		public const float NormalAngleUpperLimit = 359.9999f;

		// Token: 0x040000AD RID: 173
		private static readonly ContactFilter2D.IsFilteringNormalAngle_InjectedDelegate IsFilteringNormalAngle_InjectedDelegateField;

		// Token: 0x040000AE RID: 174
		private static readonly ContactFilter2D.IsFilteringNormalAngleUsingAngle_InjectedDelegate IsFilteringNormalAngleUsingAngle_InjectedDelegateField;

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000564 RID: 1380
		private delegate bool IsFilteringNormalAngle_InjectedDelegate(IntPtr _unity_self, IntPtr normal);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000566 RID: 1382
		private delegate bool IsFilteringNormalAngleUsingAngle_InjectedDelegate(IntPtr _unity_self, float angle);
	}
}
