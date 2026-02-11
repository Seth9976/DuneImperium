using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000E RID: 14
	public class NativeMethodAttribute : Attribute
	{
		// Token: 0x06000051 RID: 81 RVA: 0x000033F4 File Offset: 0x000015F4
		// Note: this type is marked as 'beforefieldinit'.
		static NativeMethodAttribute()
		{
			Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr);
			NativeMethodAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, "<Name>k__BackingField");
			NativeMethodAttribute.NativeFieldInfoPtr__IsThreadSafe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, "<IsThreadSafe>k__BackingField");
			NativeMethodAttribute.NativeFieldInfoPtr__IsFreeFunction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, "<IsFreeFunction>k__BackingField");
			NativeMethodAttribute.NativeFieldInfoPtr__ThrowsException_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, "<ThrowsException>k__BackingField");
			NativeMethodAttribute.NativeFieldInfoPtr__HasExplicitThis_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, "<HasExplicitThis>k__BackingField");
			NativeMethodAttribute.NativeMethodInfoPtr_set_Name_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663320);
			NativeMethodAttribute.NativeMethodInfoPtr_set_IsThreadSafe_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663321);
			NativeMethodAttribute.NativeMethodInfoPtr_set_IsFreeFunction_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663322);
			NativeMethodAttribute.NativeMethodInfoPtr_set_ThrowsException_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663323);
			NativeMethodAttribute.NativeMethodInfoPtr_set_HasExplicitThis_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663324);
			NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663325);
			NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663326);
			NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663327);
			NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr, 100663328);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002416 File Offset: 0x00000616
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000353C File Offset: 0x0000173C
		public unsafe virtual string Name
		{
			get
			{
				return this._Name_k__BackingField;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr_set_Name_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000241E File Offset: 0x0000061E
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00003580 File Offset: 0x00001780
		public unsafe virtual bool IsThreadSafe
		{
			get
			{
				return this._IsThreadSafe_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr_set_IsThreadSafe_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002426 File Offset: 0x00000626
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000035C0 File Offset: 0x000017C0
		public unsafe virtual bool IsFreeFunction
		{
			get
			{
				return this._IsFreeFunction_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr_set_IsFreeFunction_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000242E File Offset: 0x0000062E
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00003600 File Offset: 0x00001800
		public unsafe virtual bool ThrowsException
		{
			get
			{
				return this._ThrowsException_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr_set_ThrowsException_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002436 File Offset: 0x00000636
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00003640 File Offset: 0x00001840
		public unsafe virtual bool HasExplicitThis
		{
			get
			{
				return this._HasExplicitThis_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr_set_HasExplicitThis_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003680 File Offset: 0x00001880
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeMethodAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000036BC File Offset: 0x000018BC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1269094, RefRangeEnd = 1269101, XrefRangeStart = 1269076, XrefRangeEnd = 1269094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeMethodAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003708 File Offset: 0x00001908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269101, XrefRangeEnd = 1269102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeMethodAttribute(string name, bool isFreeFunction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFreeFunction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003764 File Offset: 0x00001964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269102, XrefRangeEnd = 1269103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFreeFunction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isThreadSafe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002382 File Offset: 0x00000582
		public NativeMethodAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000037CC File Offset: 0x000019CC
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000238B File Offset: 0x0000058B
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000037F4 File Offset: 0x000019F4
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000023AA File Offset: 0x000005AA
		public unsafe bool _IsThreadSafe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__IsThreadSafe_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__IsThreadSafe_k__BackingField)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000381C File Offset: 0x00001A1C
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000023C5 File Offset: 0x000005C5
		public unsafe bool _IsFreeFunction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__IsFreeFunction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__IsFreeFunction_k__BackingField)) = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00003844 File Offset: 0x00001A44
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000023E0 File Offset: 0x000005E0
		public unsafe bool _ThrowsException_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__ThrowsException_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__ThrowsException_k__BackingField)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000386C File Offset: 0x00001A6C
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000023FB File Offset: 0x000005FB
		public unsafe bool _HasExplicitThis_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__HasExplicitThis_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NativeMethodAttribute.NativeFieldInfoPtr__HasExplicitThis_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000243E File Offset: 0x0000063E
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000244B File Offset: 0x0000064B
		public bool WritableSelf
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr__IsThreadSafe_k__BackingField;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr__IsFreeFunction_k__BackingField;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr__ThrowsException_k__BackingField;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr__HasExplicitThis_k__BackingField;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_set_IsThreadSafe_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFreeFunction_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_set_ThrowsException_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_set_HasExplicitThis_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0;
	}
}
