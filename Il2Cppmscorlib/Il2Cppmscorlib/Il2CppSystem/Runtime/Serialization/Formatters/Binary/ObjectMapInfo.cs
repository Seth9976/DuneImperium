using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000365 RID: 869
	public sealed class ObjectMapInfo : Object
	{
		// Token: 0x060034D7 RID: 13527 RVA: 0x00106B28 File Offset: 0x00104D28
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectMapInfo()
		{
			Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectMapInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr);
			ObjectMapInfo.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, "objectId");
			ObjectMapInfo.NativeFieldInfoPtr_numMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, "numMembers");
			ObjectMapInfo.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, "memberNames");
			ObjectMapInfo.NativeFieldInfoPtr_memberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, "memberTypes");
			ObjectMapInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, 100671394);
			ObjectMapInfo.NativeMethodInfoPtr_isCompatible_Internal_Boolean_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr, 100671395);
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x00106BD0 File Offset: 0x00104DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388473, XrefRangeEnd = 1388476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectMapInfo(int objectId, int numMembers, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectMapInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numMembers;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMapInfo.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x00106C4C File Offset: 0x00104E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388476, XrefRangeEnd = 1388477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isCompatible(int numMembers, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numMembers;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMapInfo.NativeMethodInfoPtr_isCompatible_Internal_Boolean_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x00012B54 File Offset: 0x00010D54
		public ObjectMapInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060034DB RID: 13531 RVA: 0x00106CBC File Offset: 0x00104EBC
		// (set) Token: 0x060034DC RID: 13532 RVA: 0x00012B5D File Offset: 0x00010D5D
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060034DD RID: 13533 RVA: 0x00106CE4 File Offset: 0x00104EE4
		// (set) Token: 0x060034DE RID: 13534 RVA: 0x00012B78 File Offset: 0x00010D78
		public unsafe int numMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_numMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_numMembers)) = value;
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x060034DF RID: 13535 RVA: 0x00106D0C File Offset: 0x00104F0C
		// (set) Token: 0x060034E0 RID: 13536 RVA: 0x00012B93 File Offset: 0x00010D93
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060034E1 RID: 13537 RVA: 0x00106D3C File Offset: 0x00104F3C
		// (set) Token: 0x060034E2 RID: 13538 RVA: 0x00012BB2 File Offset: 0x00010DB2
		public unsafe Il2CppReferenceArray<Type> memberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_memberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMapInfo.NativeFieldInfoPtr_memberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B54 RID: 11092
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002B55 RID: 11093
		private static readonly IntPtr NativeFieldInfoPtr_numMembers;

		// Token: 0x04002B56 RID: 11094
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04002B57 RID: 11095
		private static readonly IntPtr NativeFieldInfoPtr_memberTypes;

		// Token: 0x04002B58 RID: 11096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04002B59 RID: 11097
		private static readonly IntPtr NativeMethodInfoPtr_isCompatible_Internal_Boolean_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_0;
	}
}
