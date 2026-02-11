using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;

namespace voodoo
{
	// Token: 0x0200001C RID: 28
	public class VersionedDataComponentObserver<T> : Observer where T : DataComponent
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x0000BA2C File Offset: 0x00009C2C
		// Note: this type is marked as 'beforefieldinit'.
		static VersionedDataComponentObserver()
		{
			Il2CppClassPointerStore<VersionedDataComponentObserver<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("voodoo.dll", "voodoo", "VersionedDataComponentObserver`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionedDataComponentObserver<T>>.NativeClassPtr);
			VersionedDataComponentObserver<T>.NativeFieldInfoPtr_Model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedDataComponentObserver<T>>.NativeClassPtr, "Model");
			VersionedDataComponentObserver<T>.NativeFieldInfoPtr_composition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedDataComponentObserver<T>>.NativeClassPtr, "composition");
			VersionedDataComponentObserver<T>.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedDataComponentObserver<T>>.NativeClassPtr, "cachedVersion");
			VersionedDataComponentObserver<T>.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedDataComponentObserver<T>>.NativeClassPtr, 100663394);
			VersionedDataComponentObserver<T>.NativeMethodInfoPtr_clearModel_Private_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedDataComponentObserver<T>>.NativeClassPtr, 100663395);
			VersionedDataComponentObserver<T>.NativeMethodInfoPtr_versionChanged_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedDataComponentObserver<T>>.NativeClassPtr, 100663396);
			VersionedDataComponentObserver<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedDataComponentObserver<T>>.NativeClassPtr, 100663397);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000BB24 File Offset: 0x00009D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1107007, RefRangeEnd = 1107008, XrefRangeStart = 1106967, XrefRangeEnd = 1107007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedDataComponentObserver<T>.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000BB60 File Offset: 0x00009D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1107008, XrefRangeEnd = 1107016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void clearModel(PoolableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedDataComponentObserver<T>.NativeMethodInfoPtr_clearModel_Private_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000BBA4 File Offset: 0x00009DA4
		[CallerCount(0)]
		public unsafe virtual void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedDataComponentObserver<T>.NativeMethodInfoPtr_versionChanged_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionedDataComponentObserver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedDataComponentObserver<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedDataComponentObserver<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000027D2 File Offset: 0x000009D2
		public VersionedDataComponentObserver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000BC1C File Offset: 0x00009E1C
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000BC44 File Offset: 0x00009E44
		public unsafe T Model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedDataComponentObserver<T>.NativeFieldInfoPtr_Model);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedDataComponentObserver<T>.NativeFieldInfoPtr_Model);
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

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000BCEC File Offset: 0x00009EEC
		// (set) Token: 0x060000DE RID: 222 RVA: 0x000027DB File Offset: 0x000009DB
		public unsafe DataComposition composition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedDataComponentObserver<T>.NativeFieldInfoPtr_composition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedDataComponentObserver<T>.NativeFieldInfoPtr_composition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000BD1C File Offset: 0x00009F1C
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x000027FA File Offset: 0x000009FA
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedDataComponentObserver<T>.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedDataComponentObserver<T>.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_Model;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_composition;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_clearModel_Private_Void_PoolableItem_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
