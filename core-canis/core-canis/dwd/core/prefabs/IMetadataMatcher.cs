using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.prefabs
{
	// Token: 0x02000103 RID: 259
	public class IMetadataMatcher<MetaType> : Il2CppObjectBase where MetaType : new()
	{
		// Token: 0x06000F18 RID: 3864 RVA: 0x0004F958 File Offset: 0x0004DB58
		// Note: this type is marked as 'beforefieldinit'.
		static IMetadataMatcher()
		{
			Il2CppClassPointerStore<IMetadataMatcher<MetaType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs", "IMetadataMatcher`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MetaType>.NativeClassPtr)) })).TypeHandle.value);
			IMetadataMatcher<MetaType>.NativeMethodInfoPtr_Match_Public_Abstract_Virtual_New_Boolean_MetaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMetadataMatcher<MetaType>>.NativeClassPtr, 100665492);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0004F9D0 File Offset: 0x0004DBD0
		[CallerCount(0)]
		public unsafe virtual bool Match(MetaType metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(MetaType).IsValueType)
				{
					MetaType metaType = metadata;
					intPtr = ((metaType is string) ? IL2CPP.ManagedStringToIl2Cpp(metaType as string) : IL2CPP.Il2CppObjectBaseToPtr(metaType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref metadata;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMetadataMatcher<MetaType>.NativeMethodInfoPtr_Match_Public_Abstract_Virtual_New_Boolean_MetaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x000071D6 File Offset: 0x000053D6
		public IMetadataMatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Abstract_Virtual_New_Boolean_MetaType_0;
	}
}
