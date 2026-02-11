using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Unity.Properties
{
	// Token: 0x0200001A RID: 26
	public class SetPropertyBagBase<TSet, TElement> : PropertyBag<TSet>
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00005F04 File Offset: 0x00004104
		// Note: this type is marked as 'beforefieldinit'.
		static SetPropertyBagBase()
		{
			Il2CppClassPointerStore<SetPropertyBagBase<TSet, TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "SetPropertyBagBase`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSet>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPropertyBagBase<TSet, TElement>>.NativeClassPtr);
			SetPropertyBagBase<TSet, TElement>.NativeFieldInfoPtr_m_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPropertyBagBase<TSet, TElement>>.NativeClassPtr, "m_Property");
			SetPropertyBagBase<TSet, TElement>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyBagBase<TSet, TElement>>.NativeClassPtr, 100663380);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00005FAC File Offset: 0x000041AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetPropertyBagBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetPropertyBagBase<TSet, TElement>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPropertyBagBase<TSet, TElement>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002650 File Offset: 0x00000850
		public SetPropertyBagBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00005FE8 File Offset: 0x000041E8
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00002659 File Offset: 0x00000859
		public unsafe SetPropertyBagBase<TSet, TElement>.SetElementProperty m_Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPropertyBagBase<TSet, TElement>.NativeFieldInfoPtr_m_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetPropertyBagBase<TSet, TElement>.SetElementProperty>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPropertyBagBase<TSet, TElement>.NativeFieldInfoPtr_m_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002678 File Offset: 0x00000878
		public IEnumerable<IProperty<TSet>> GetPropertiesEnumerable(TSet container)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002685 File Offset: 0x00000885
		public void Unity.Properties.ICollectionPropertyBagAccept<TSet>.Accept(ICollectionPropertyBagVisitor visitor, ref TSet container)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002692 File Offset: 0x00000892
		public void Unity.Properties.ISetPropertyBagAccept<TSet>.Accept(ISetPropertyBagVisitor visitor, ref TSet container)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000269F File Offset: 0x0000089F
		public void Unity.Properties.ISetPropertyAccept<TSet>.Accept<TContainer>(ISetPropertyVisitor visitor, Property<TContainer, TSet> property, ref TContainer container, ref TSet dictionary)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00006018 File Offset: 0x00004218
		public bool TryGetProperty(ref TSet container, Object key, out IProperty<TSet> property)
		{
			bool flag = container.Contains(key.Cast<TElement>());
			bool flag2;
			if (flag)
			{
				property = new SetPropertyBagBase<TSet, TElement>.SetElementProperty
				{
					m_Value = key.Cast<TElement>()
				};
				flag2 = true;
			}
			else
			{
				property = null;
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_m_Property;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000065 RID: 101
		public class SetElementProperty : Property<TSet, TElement>
		{
			// Token: 0x06000217 RID: 535 RVA: 0x000091BC File Offset: 0x000073BC
			// Note: this type is marked as 'beforefieldinit'.
			static SetElementProperty()
			{
				Il2CppClassPointerStore<SetPropertyBagBase<TSet, TElement>.SetElementProperty>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetPropertyBagBase<TSet, TElement>>.NativeClassPtr, "SetElementProperty"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSet>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPropertyBagBase<TSet, TElement>.SetElementProperty>.NativeClassPtr);
				SetPropertyBagBase<TSet, TElement>.SetElementProperty.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPropertyBagBase<TSet, TElement>.SetElementProperty>.NativeClassPtr, "m_Value");
				SetPropertyBagBase<TSet, TElement>.SetElementProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyBagBase<TSet, TElement>.SetElementProperty>.NativeClassPtr, 100663381);
				SetPropertyBagBase<TSet, TElement>.SetElementProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPropertyBagBase<TSet, TElement>.SetElementProperty>.NativeClassPtr, 100663382);
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x06000218 RID: 536 RVA: 0x00009270 File Offset: 0x00007470
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230923, XrefRangeEnd = 1230928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetPropertyBagBase<TSet, TElement>.SetElementProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000219 RID: 537 RVA: 0x000092B4 File Offset: 0x000074B4
			[CallerCount(0)]
			public unsafe SetElementProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetPropertyBagBase<TSet, TElement>.SetElementProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetPropertyBagBase<TSet, TElement>.SetElementProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600021A RID: 538 RVA: 0x00003180 File Offset: 0x00001380
			public SetElementProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x0600021B RID: 539 RVA: 0x000092F0 File Offset: 0x000074F0
			// (set) Token: 0x0600021C RID: 540 RVA: 0x00009318 File Offset: 0x00007518
			public unsafe TElement m_Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPropertyBagBase<TSet, TElement>.SetElementProperty.NativeFieldInfoPtr_m_Value);
					return IL2CPP.PointerToValueGeneric<TElement>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetPropertyBagBase<TSet, TElement>.SetElementProperty.NativeFieldInfoPtr_m_Value);
					Type typeFromHandle = typeof(TElement);
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

			// Token: 0x040000FD RID: 253
			private static readonly IntPtr NativeFieldInfoPtr_m_Value;

			// Token: 0x040000FE RID: 254
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x040000FF RID: 255
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
