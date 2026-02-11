using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.ResourceManagement.ResourceLocations
{
	// Token: 0x02000047 RID: 71
	public class IResourceLocation : Il2CppObjectBase
	{
		// Token: 0x06000371 RID: 881 RVA: 0x00012434 File Offset: 0x00010634
		// Note: this type is marked as 'beforefieldinit'.
		static IResourceLocation()
		{
			Il2CppClassPointerStore<IResourceLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceLocations", "IResourceLocation");
			IResourceLocation.NativeMethodInfoPtr_get_InternalId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceLocation>.NativeClassPtr, 100663891);
			IResourceLocation.NativeMethodInfoPtr_get_ProviderId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceLocation>.NativeClassPtr, 100663892);
			IResourceLocation.NativeMethodInfoPtr_get_Dependencies_Public_Abstract_Virtual_New_get_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceLocation>.NativeClassPtr, 100663893);
			IResourceLocation.NativeMethodInfoPtr_Hash_Public_Abstract_Virtual_New_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceLocation>.NativeClassPtr, 100663894);
			IResourceLocation.NativeMethodInfoPtr_get_DependencyHashCode_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceLocation>.NativeClassPtr, 100663895);
			IResourceLocation.NativeMethodInfoPtr_get_HasDependencies_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceLocation>.NativeClassPtr, 100663896);
			IResourceLocation.NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceLocation>.NativeClassPtr, 100663897);
			IResourceLocation.NativeMethodInfoPtr_get_PrimaryKey_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceLocation>.NativeClassPtr, 100663898);
			IResourceLocation.NativeMethodInfoPtr_get_ResourceType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceLocation>.NativeClassPtr, 100663899);
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00012510 File Offset: 0x00010710
		public unsafe virtual string InternalId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceLocation.NativeMethodInfoPtr_get_InternalId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00012554 File Offset: 0x00010754
		public unsafe virtual string ProviderId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceLocation.NativeMethodInfoPtr_get_ProviderId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00012598 File Offset: 0x00010798
		public unsafe virtual IList<IResourceLocation> Dependencies
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceLocation.NativeMethodInfoPtr_get_Dependencies_Public_Abstract_Virtual_New_get_IList_1_IResourceLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IResourceLocation>>(intPtr3) : null;
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000125E4 File Offset: 0x000107E4
		[CallerCount(0)]
		public unsafe virtual int Hash(Type resultType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resultType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceLocation.NativeMethodInfoPtr_Hash_Public_Abstract_Virtual_New_Int32_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0001263C File Offset: 0x0001083C
		public unsafe virtual int DependencyHashCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceLocation.NativeMethodInfoPtr_get_DependencyHashCode_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00012684 File Offset: 0x00010884
		public unsafe virtual bool HasDependencies
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceLocation.NativeMethodInfoPtr_get_HasDependencies_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000378 RID: 888 RVA: 0x000126CC File Offset: 0x000108CC
		public unsafe virtual Object Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceLocation.NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00012718 File Offset: 0x00010918
		public unsafe virtual string PrimaryKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceLocation.NativeMethodInfoPtr_get_PrimaryKey_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0001275C File Offset: 0x0001095C
		public unsafe virtual Type ResourceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceLocation.NativeMethodInfoPtr_get_ResourceType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000035EB File Offset: 0x000017EB
		public IResourceLocation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalId_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_get_ProviderId_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_get_Dependencies_Public_Abstract_Virtual_New_get_IList_1_IResourceLocation_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_Hash_Public_Abstract_Virtual_New_Int32_Type_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_get_DependencyHashCode_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDependencies_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_get_PrimaryKey_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceType_Public_Abstract_Virtual_New_get_Type_0;
	}
}
