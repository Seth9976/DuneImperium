using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.prefabs
{
	// Token: 0x0200010C RID: 268
	[Serializable]
	public class PrefabLookupEntry<MetaType> : PrefabLookupEntry where MetaType : new()
	{
		// Token: 0x06000F52 RID: 3922 RVA: 0x000509AC File Offset: 0x0004EBAC
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabLookupEntry()
		{
			Il2CppClassPointerStore<PrefabLookupEntry<MetaType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs", "PrefabLookupEntry`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<MetaType>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabLookupEntry<MetaType>>.NativeClassPtr);
			PrefabLookupEntry<MetaType>.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLookupEntry<MetaType>>.NativeClassPtr, "Metadata");
			PrefabLookupEntry<MetaType>.NativeMethodInfoPtr__ctor_Public_Void_MetaType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookupEntry<MetaType>>.NativeClassPtr, 100665534);
			PrefabLookupEntry<MetaType>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookupEntry<MetaType>>.NativeClassPtr, 100665535);
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00050A54 File Offset: 0x0004EC54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 868214, RefRangeEnd = 868217, XrefRangeStart = 868208, XrefRangeEnd = 868214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabLookupEntry(MetaType Metadata, string resourcePath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLookupEntry<MetaType>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(MetaType).IsValueType)
				{
					MetaType metaType = Metadata;
					intPtr = ((metaType is string) ? IL2CPP.ManagedStringToIl2Cpp(metaType as string) : IL2CPP.Il2CppObjectBaseToPtr(metaType as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref Metadata;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(resourcePath);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PrefabLookupEntry<MetaType>.NativeMethodInfoPtr__ctor_Public_Void_MetaType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00050AE8 File Offset: 0x0004ECE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868217, XrefRangeEnd = 868222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookupEntry<MetaType>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x000072BA File Offset: 0x000054BA
		public PrefabLookupEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x00050B2C File Offset: 0x0004ED2C
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x00050B54 File Offset: 0x0004ED54
		public unsafe MetaType Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLookupEntry<MetaType>.NativeFieldInfoPtr_Metadata);
				return IL2CPP.PointerToValueGeneric<MetaType>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLookupEntry<MetaType>.NativeFieldInfoPtr_Metadata);
				Type typeFromHandle = typeof(MetaType);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MetaType_String_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
