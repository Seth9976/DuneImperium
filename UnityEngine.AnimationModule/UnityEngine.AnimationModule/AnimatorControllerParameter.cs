using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001A RID: 26
	public class AnimatorControllerParameter : Object
	{
		// Token: 0x060001FF RID: 511 RVA: 0x0000E484 File Offset: 0x0000C684
		// Note: this type is marked as 'beforefieldinit'.
		static AnimatorControllerParameter()
		{
			Il2CppClassPointerStore<AnimatorControllerParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "AnimatorControllerParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorControllerParameter>.NativeClassPtr);
			AnimatorControllerParameter.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorControllerParameter>.NativeClassPtr, "m_Name");
			AnimatorControllerParameter.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorControllerParameter>.NativeClassPtr, "m_Type");
			AnimatorControllerParameter.NativeFieldInfoPtr_m_DefaultFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorControllerParameter>.NativeClassPtr, "m_DefaultFloat");
			AnimatorControllerParameter.NativeFieldInfoPtr_m_DefaultInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorControllerParameter>.NativeClassPtr, "m_DefaultInt");
			AnimatorControllerParameter.NativeFieldInfoPtr_m_DefaultBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorControllerParameter>.NativeClassPtr, "m_DefaultBool");
			AnimatorControllerParameter.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerParameter>.NativeClassPtr, 100663693);
			AnimatorControllerParameter.NativeMethodInfoPtr_get_nameHash_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerParameter>.NativeClassPtr, 100663694);
			AnimatorControllerParameter.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerParameter>.NativeClassPtr, 100663695);
			AnimatorControllerParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerParameter>.NativeClassPtr, 100663696);
			AnimatorControllerParameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorControllerParameter>.NativeClassPtr, 100663697);
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000E57C File Offset: 0x0000C77C
		public unsafe string name
		{
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerParameter.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000E5B4 File Offset: 0x0000C7B4
		public unsafe int nameHash
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1220688, RefRangeEnd = 1220698, XrefRangeStart = 1220686, XrefRangeEnd = 1220688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerParameter.NativeMethodInfoPtr_get_nameHash_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000E5F0 File Offset: 0x0000C7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220698, XrefRangeEnd = 1220703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimatorControllerParameter.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000E648 File Offset: 0x0000C848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AnimatorControllerParameter.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000E690 File Offset: 0x0000C890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220703, XrefRangeEnd = 1220708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimatorControllerParameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorControllerParameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimatorControllerParameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000244D File Offset: 0x0000064D
		public AnimatorControllerParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000E6CC File Offset: 0x0000C8CC
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002456 File Offset: 0x00000656
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorControllerParameter.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorControllerParameter.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000E6F4 File Offset: 0x0000C8F4
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002475 File Offset: 0x00000675
		public unsafe AnimatorControllerParameterType m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorControllerParameter.NativeFieldInfoPtr_m_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorControllerParameter.NativeFieldInfoPtr_m_Type)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0000E71C File Offset: 0x0000C91C
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00002490 File Offset: 0x00000690
		public unsafe float m_DefaultFloat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorControllerParameter.NativeFieldInfoPtr_m_DefaultFloat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorControllerParameter.NativeFieldInfoPtr_m_DefaultFloat)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0000E744 File Offset: 0x0000C944
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000024AB File Offset: 0x000006AB
		public unsafe int m_DefaultInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorControllerParameter.NativeFieldInfoPtr_m_DefaultInt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorControllerParameter.NativeFieldInfoPtr_m_DefaultInt)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000E76C File Offset: 0x0000C96C
		// (set) Token: 0x0600020F RID: 527 RVA: 0x000024C6 File Offset: 0x000006C6
		public unsafe bool m_DefaultBool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorControllerParameter.NativeFieldInfoPtr_m_DefaultBool);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimatorControllerParameter.NativeFieldInfoPtr_m_DefaultBool)) = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000E794 File Offset: 0x0000C994
		// (set) Token: 0x06000211 RID: 529 RVA: 0x000024E1 File Offset: 0x000006E1
		public AnimatorControllerParameterType type
		{
			get
			{
				return this.m_Type;
			}
			set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000E7AC File Offset: 0x0000C9AC
		// (set) Token: 0x06000213 RID: 531 RVA: 0x000024EB File Offset: 0x000006EB
		public float defaultFloat
		{
			get
			{
				return this.m_DefaultFloat;
			}
			set
			{
				this.m_DefaultFloat = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
		// (set) Token: 0x06000215 RID: 533 RVA: 0x000024F5 File Offset: 0x000006F5
		public int defaultInt
		{
			get
			{
				return this.m_DefaultInt;
			}
			set
			{
				this.m_DefaultInt = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000E7DC File Offset: 0x0000C9DC
		// (set) Token: 0x06000217 RID: 535 RVA: 0x000024FF File Offset: 0x000006FF
		public bool defaultBool
		{
			get
			{
				return this.m_DefaultBool;
			}
			set
			{
				this.m_DefaultBool = value;
			}
		}

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultFloat;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultInt;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_m_DefaultBool;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_get_nameHash_Public_get_Int32_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
