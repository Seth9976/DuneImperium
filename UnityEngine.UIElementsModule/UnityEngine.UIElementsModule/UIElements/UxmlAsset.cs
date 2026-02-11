using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200020F RID: 527
	[Serializable]
	public class UxmlAsset : Object
	{
		// Token: 0x06002832 RID: 10290 RVA: 0x000B0D8C File Offset: 0x000AEF8C
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlAsset()
		{
			Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr);
			UxmlAsset.NativeFieldInfoPtr_m_FullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr, "m_FullTypeName");
			UxmlAsset.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr, "m_Id");
			UxmlAsset.NativeFieldInfoPtr_m_OrderInDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr, "m_OrderInDocument");
			UxmlAsset.NativeFieldInfoPtr_m_ParentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr, "m_ParentId");
			UxmlAsset.NativeFieldInfoPtr_m_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr, "m_Properties");
			UxmlAsset.NativeMethodInfoPtr_get_fullTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr, 100669341);
			UxmlAsset.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr, 100669342);
			UxmlAsset.NativeMethodInfoPtr_get_orderInDocument_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr, 100669343);
			UxmlAsset.NativeMethodInfoPtr_get_parentId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr, 100669344);
			UxmlAsset.NativeMethodInfoPtr_TryGetAttributeValue_Public_Virtual_Final_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr, 100669345);
			UxmlAsset.NativeMethodInfoPtr_SetAttribute_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr, 100669346);
			UxmlAsset.NativeMethodInfoPtr_SetOrAddProperty_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAsset>.NativeClassPtr, 100669347);
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x000B0EAC File Offset: 0x000AF0AC
		// (set) Token: 0x06002845 RID: 10309 RVA: 0x0001040B File Offset: 0x0000E60B
		public unsafe string fullTypeName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAsset.NativeMethodInfoPtr_get_fullTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this.m_FullTypeName = value;
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06002834 RID: 10292 RVA: 0x000B0EE4 File Offset: 0x000AF0E4
		// (set) Token: 0x06002846 RID: 10310 RVA: 0x00010414 File Offset: 0x0000E614
		public unsafe int id
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAsset.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Id = value;
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x000B0F20 File Offset: 0x000AF120
		// (set) Token: 0x06002847 RID: 10311 RVA: 0x0001041D File Offset: 0x0000E61D
		public unsafe int orderInDocument
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAsset.NativeMethodInfoPtr_get_orderInDocument_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_OrderInDocument = value;
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06002836 RID: 10294 RVA: 0x000B0F5C File Offset: 0x000AF15C
		// (set) Token: 0x06002848 RID: 10312 RVA: 0x00010426 File Offset: 0x0000E626
		public unsafe int parentId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAsset.NativeMethodInfoPtr_get_parentId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_ParentId = value;
			}
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x000B0F98 File Offset: 0x000AF198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344196, XrefRangeEnd = 344207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetAttributeValue(string propertyName, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UxmlAsset.NativeMethodInfoPtr_TryGetAttributeValue_Public_Virtual_Final_New_Boolean_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x000B1000 File Offset: 0x000AF200
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 344224, RefRangeEnd = 344227, XrefRangeStart = 344207, XrefRangeEnd = 344224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttribute(string name, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAsset.NativeMethodInfoPtr_SetAttribute_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x000B1054 File Offset: 0x000AF254
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 344224, RefRangeEnd = 344227, XrefRangeStart = 344224, XrefRangeEnd = 344227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOrAddProperty(string propertyName, string propertyValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAsset.NativeMethodInfoPtr_SetOrAddProperty_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00010373 File Offset: 0x0000E573
		public UxmlAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x000B10A8 File Offset: 0x000AF2A8
		// (set) Token: 0x0600283C RID: 10300 RVA: 0x0001037C File Offset: 0x0000E57C
		public unsafe string m_FullTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAsset.NativeFieldInfoPtr_m_FullTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAsset.NativeFieldInfoPtr_m_FullTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x000B10D0 File Offset: 0x000AF2D0
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x0001039B File Offset: 0x0000E59B
		public unsafe int m_Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAsset.NativeFieldInfoPtr_m_Id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAsset.NativeFieldInfoPtr_m_Id)) = value;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x000B10F8 File Offset: 0x000AF2F8
		// (set) Token: 0x06002840 RID: 10304 RVA: 0x000103B6 File Offset: 0x0000E5B6
		public unsafe int m_OrderInDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAsset.NativeFieldInfoPtr_m_OrderInDocument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAsset.NativeFieldInfoPtr_m_OrderInDocument)) = value;
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06002841 RID: 10305 RVA: 0x000B1120 File Offset: 0x000AF320
		// (set) Token: 0x06002842 RID: 10306 RVA: 0x000103D1 File Offset: 0x0000E5D1
		public unsafe int m_ParentId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAsset.NativeFieldInfoPtr_m_ParentId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAsset.NativeFieldInfoPtr_m_ParentId)) = value;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06002843 RID: 10307 RVA: 0x000B1148 File Offset: 0x000AF348
		// (set) Token: 0x06002844 RID: 10308 RVA: 0x000103EC File Offset: 0x0000E5EC
		public unsafe List<string> m_Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAsset.NativeFieldInfoPtr_m_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAsset.NativeFieldInfoPtr_m_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x0001042F File Offset: 0x0000E62F
		public List<string> GetProperties()
		{
			return this.m_Properties;
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00010437 File Offset: 0x0000E637
		public bool HasParent()
		{
			return this.m_ParentId != 0;
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x000B1178 File Offset: 0x000AF378
		public bool HasAttribute(string attributeName)
		{
			bool flag = this.m_Properties == null || this.m_Properties.Count <= 0;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				for (int i = 0; i < this.m_Properties.Count; i += 2)
				{
					string text = this.m_Properties[i];
					bool flag3 = text == attributeName;
					if (flag3)
					{
						return true;
					}
				}
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x000B11EC File Offset: 0x000AF3EC
		public string GetAttributeValue(string attributeName)
		{
			string text;
			this.TryGetAttributeValue(attributeName, out text);
			return text;
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x000B120C File Offset: 0x000AF40C
		public void RemoveAttribute(string attributeName)
		{
			bool flag = this.m_Properties == null || this.m_Properties.Count <= 0;
			if (!flag)
			{
				for (int i = 0; i < this.m_Properties.Count; i += 2)
				{
					string text = this.m_Properties[i];
					bool flag2 = text != attributeName;
					if (!flag2)
					{
						this.m_Properties.RemoveAt(i);
						this.m_Properties.RemoveAt(i);
						break;
					}
				}
			}
		}

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeFieldInfoPtr_m_FullTypeName;

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeFieldInfoPtr_m_OrderInDocument;

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeFieldInfoPtr_m_ParentId;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeFieldInfoPtr_m_Properties;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeMethodInfoPtr_get_fullTypeName_Public_get_String_0;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeMethodInfoPtr_get_orderInDocument_Public_get_Int32_0;

		// Token: 0x04001C7A RID: 7290
		private static readonly IntPtr NativeMethodInfoPtr_get_parentId_Public_get_Int32_0;

		// Token: 0x04001C7B RID: 7291
		private static readonly IntPtr NativeMethodInfoPtr_TryGetAttributeValue_Public_Virtual_Final_New_Boolean_String_byref_String_0;

		// Token: 0x04001C7C RID: 7292
		private static readonly IntPtr NativeMethodInfoPtr_SetAttribute_Public_Void_String_String_0;

		// Token: 0x04001C7D RID: 7293
		private static readonly IntPtr NativeMethodInfoPtr_SetOrAddProperty_Private_Void_String_String_0;
	}
}
