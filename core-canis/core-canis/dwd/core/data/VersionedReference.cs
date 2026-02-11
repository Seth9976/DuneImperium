using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace dwd.core.data
{
	// Token: 0x020001CD RID: 461
	public class VersionedReference<T> : Object
	{
		// Token: 0x06001982 RID: 6530 RVA: 0x00079414 File Offset: 0x00077614
		// Note: this type is marked as 'beforefieldinit'.
		static VersionedReference()
		{
			Il2CppClassPointerStore<VersionedReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data", "VersionedReference`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionedReference<T>>.NativeClassPtr);
			VersionedReference<T>.NativeFieldInfoPtr_referencedModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedReference<T>>.NativeClassPtr, "referencedModel");
			VersionedReference<T>.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedReference<T>>.NativeClassPtr, "cachedVersion");
			VersionedReference<T>.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedReference<T>>.NativeClassPtr, "version");
			VersionedReference<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedReference<T>>.NativeClassPtr, 100667350);
			VersionedReference<T>.NativeMethodInfoPtr_SetModel_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedReference<T>>.NativeClassPtr, 100667351);
			VersionedReference<T>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedReference<T>>.NativeClassPtr, 100667352);
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x000794F8 File Offset: 0x000776F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881410, XrefRangeEnd = 881417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionedReference(T model)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedReference<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = model;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref model;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VersionedReference<T>.NativeMethodInfoPtr__ctor_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x0007957C File Offset: 0x0007777C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881417, XrefRangeEnd = 881423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetModel(T model)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = model;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref model;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VersionedReference<T>.NativeMethodInfoPtr_SetModel_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x000795F4 File Offset: 0x000777F4
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881423, XrefRangeEnd = 881442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedReference<T>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x0000B2BF File Offset: 0x000094BF
		public VersionedReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x00079630 File Offset: 0x00077830
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x00079658 File Offset: 0x00077858
		public unsafe T referencedModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedReference<T>.NativeFieldInfoPtr_referencedModel);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedReference<T>.NativeFieldInfoPtr_referencedModel);
				Type typeFromHandle = typeof(T);
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

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x00079700 File Offset: 0x00077900
		// (set) Token: 0x0600198A RID: 6538 RVA: 0x0000B2C8 File Offset: 0x000094C8
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedReference<T>.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedReference<T>.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x00079728 File Offset: 0x00077928
		// (set) Token: 0x0600198C RID: 6540 RVA: 0x0000B2E3 File Offset: 0x000094E3
		public unsafe ulong version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedReference<T>.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedReference<T>.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeFieldInfoPtr_referencedModel;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_0;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeMethodInfoPtr_SetModel_Public_Void_T_0;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;
	}
}
