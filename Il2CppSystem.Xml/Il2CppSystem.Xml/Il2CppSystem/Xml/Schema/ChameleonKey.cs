using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200010B RID: 267
	public class ChameleonKey : Object
	{
		// Token: 0x0600181F RID: 6175 RVA: 0x0007D5F8 File Offset: 0x0007B7F8
		// Note: this type is marked as 'beforefieldinit'.
		static ChameleonKey()
		{
			Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ChameleonKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr);
			ChameleonKey.NativeFieldInfoPtr_targetNS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, "targetNS");
			ChameleonKey.NativeFieldInfoPtr_chameleonLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, "chameleonLocation");
			ChameleonKey.NativeFieldInfoPtr_originalSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, "originalSchema");
			ChameleonKey.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, "hashCode");
			ChameleonKey.NativeMethodInfoPtr__ctor_Public_Void_String_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, 100667063);
			ChameleonKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, 100667064);
			ChameleonKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr, 100667065);
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0007D6B4 File Offset: 0x0007B8B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391813, RefRangeEnd = 391815, XrefRangeStart = 391808, XrefRangeEnd = 391813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChameleonKey(string ns, XmlSchema originalSchema)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChameleonKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalSchema);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChameleonKey.NativeMethodInfoPtr__ctor_Public_Void_String_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x0007D714 File Offset: 0x0007B914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391815, XrefRangeEnd = 391816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChameleonKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0007D75C File Offset: 0x0007B95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391816, XrefRangeEnd = 391820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChameleonKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0000A468 File Offset: 0x00008668
		public ChameleonKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x0007D7B4 File Offset: 0x0007B9B4
		// (set) Token: 0x06001825 RID: 6181 RVA: 0x0000A471 File Offset: 0x00008671
		public unsafe string targetNS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_targetNS);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_targetNS), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x0007D7DC File Offset: 0x0007B9DC
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x0000A490 File Offset: 0x00008690
		public unsafe Uri chameleonLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_chameleonLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_chameleonLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x0007D80C File Offset: 0x0007BA0C
		// (set) Token: 0x06001829 RID: 6185 RVA: 0x0000A4AF File Offset: 0x000086AF
		public unsafe XmlSchema originalSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_originalSchema);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_originalSchema), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x0007D83C File Offset: 0x0007BA3C
		// (set) Token: 0x0600182B RID: 6187 RVA: 0x0000A4CE File Offset: 0x000086CE
		public unsafe int hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChameleonKey.NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeFieldInfoPtr_targetNS;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeFieldInfoPtr_chameleonLocation;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeFieldInfoPtr_originalSchema;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_XmlSchema_0;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
	}
}
