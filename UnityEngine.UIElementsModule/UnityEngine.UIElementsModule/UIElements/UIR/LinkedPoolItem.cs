using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000259 RID: 601
	public class LinkedPoolItem<T> : Object
	{
		// Token: 0x06002C56 RID: 11350 RVA: 0x000BF04C File Offset: 0x000BD24C
		// Note: this type is marked as 'beforefieldinit'.
		static LinkedPoolItem()
		{
			Il2CppClassPointerStore<LinkedPoolItem<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "LinkedPoolItem`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkedPoolItem<T>>.NativeClassPtr);
			LinkedPoolItem<T>.NativeFieldInfoPtr_poolNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkedPoolItem<T>>.NativeClassPtr, "poolNext");
			LinkedPoolItem<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkedPoolItem<T>>.NativeClassPtr, 100669854);
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x000BF0E0 File Offset: 0x000BD2E0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LinkedPoolItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkedPoolItem<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LinkedPoolItem<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x00012049 File Offset: 0x00010249
		public LinkedPoolItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06002C59 RID: 11353 RVA: 0x000BF11C File Offset: 0x000BD31C
		// (set) Token: 0x06002C5A RID: 11354 RVA: 0x000BF144 File Offset: 0x000BD344
		public unsafe T poolNext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPoolItem<T>.NativeFieldInfoPtr_poolNext);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LinkedPoolItem<T>.NativeFieldInfoPtr_poolNext);
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

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeFieldInfoPtr_poolNext;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
