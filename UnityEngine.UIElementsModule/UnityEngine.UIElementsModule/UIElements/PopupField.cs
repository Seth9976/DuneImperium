using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007D RID: 125
	public class PopupField<T> : BasePopupField<T, T>
	{
		// Token: 0x06000C82 RID: 3202 RVA: 0x00049430 File Offset: 0x00047630
		// Note: this type is marked as 'beforefieldinit'.
		static PopupField()
		{
			Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PopupField`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr);
			PopupField<T>.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, "m_Index");
			PopupField<T>.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, "ussClassName");
			PopupField<T>.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, "labelUssClassName");
			PopupField<T>.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, "inputUssClassName");
			PopupField<T>.NativeMethodInfoPtr_GetValueToDisplay_Internal_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, 100665104);
			PopupField<T>.NativeMethodInfoPtr_GetListItemToDisplay_Internal_Virtual_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, 100665105);
			PopupField<T>.NativeMethodInfoPtr_get_value_Public_Virtual_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, 100665106);
			PopupField<T>.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, 100665107);
			PopupField<T>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, 100665108);
			PopupField<T>.NativeMethodInfoPtr_set_index_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, 100665109);
			PopupField<T>.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, 100665110);
			PopupField<T>.NativeMethodInfoPtr_AddMenuItems_Internal_Virtual_Void_IGenericMenu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, 100665111);
			PopupField<T>.NativeMethodInfoPtr_ChangeValueFromMenu_Private_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, 100665112);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x000495A0 File Offset: 0x000477A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302677, XrefRangeEnd = 302680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetValueToDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupField<T>.NativeMethodInfoPtr_GetValueToDisplay_Internal_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x000495E4 File Offset: 0x000477E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302680, XrefRangeEnd = 302683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetListItemToDisplay(T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupField<T>.NativeMethodInfoPtr_GetListItemToDisplay_Internal_Virtual_String_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00049670 File Offset: 0x00047870
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x000496B4 File Offset: 0x000478B4
		public unsafe override T value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302683, XrefRangeEnd = 302697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupField<T>.NativeMethodInfoPtr_get_value_Public_Virtual_get_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302697, XrefRangeEnd = 302704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupField<T>.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00049738 File Offset: 0x00047938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302704, XrefRangeEnd = 302763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(T newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = newValue;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref newValue;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupField<T>.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x000499C8 File Offset: 0x00047BC8
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x000497BC File Offset: 0x000479BC
		public unsafe int index
		{
			get
			{
				return this.m_Index;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 302764, RefRangeEnd = 302765, XrefRangeStart = 302763, XrefRangeEnd = 302764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupField<T>.NativeMethodInfoPtr_set_index_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000497FC File Offset: 0x000479FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302798, RefRangeEnd = 302800, XrefRangeStart = 302765, XrefRangeEnd = 302798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PopupField(string label = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupField<T>.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00049848 File Offset: 0x00047A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302800, XrefRangeEnd = 302829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddMenuItems(IGenericMenu menu)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(menu);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PopupField<T>.NativeMethodInfoPtr_AddMenuItems_Internal_Virtual_Void_IGenericMenu_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00049898 File Offset: 0x00047A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302830, RefRangeEnd = 302831, XrefRangeStart = 302829, XrefRangeEnd = 302830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeValueFromMenu(T menuItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = menuItem;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref menuItem;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PopupField<T>.NativeMethodInfoPtr_ChangeValueFromMenu_Private_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00006A0A File Offset: 0x00004C0A
		public PopupField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x00049910 File Offset: 0x00047B10
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x00006A13 File Offset: 0x00004C13
		public unsafe int m_Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupField<T>.NativeFieldInfoPtr_m_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupField<T>.NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00049938 File Offset: 0x00047B38
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x00006A2E File Offset: 0x00004C2E
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PopupField<T>.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PopupField<T>.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x00049958 File Offset: 0x00047B58
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00006A40 File Offset: 0x00004C40
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PopupField<T>.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PopupField<T>.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00049978 File Offset: 0x00047B78
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00006A52 File Offset: 0x00004C52
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PopupField<T>.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PopupField<T>.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00049998 File Offset: 0x00047B98
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x00006A64 File Offset: 0x00004C64
		public virtual Func<T, string> formatSelectedValueCallback
		{
			get
			{
				return base.m_FormatSelectedValueCallback;
			}
			set
			{
				base.m_FormatSelectedValueCallback = value;
				base.textElement.text = this.GetValueToDisplay();
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x000499B0 File Offset: 0x00047BB0
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x00006A80 File Offset: 0x00004C80
		public virtual Func<T, string> formatListItemCallback
		{
			get
			{
				return base.m_FormatListItemCallback;
			}
			set
			{
				base.m_FormatListItemCallback = value;
			}
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x000499E0 File Offset: 0x00047BE0
		public void SetIndexWithoutNotify(int index)
		{
			this.m_Index = index;
			bool flag = this.m_Index >= 0 && this.m_Index < base.m_Choices.Count;
			if (flag)
			{
				this.SetValueWithoutNotify(base.m_Choices[this.m_Index]);
			}
			else
			{
				this.SetValueWithoutNotify(default(T));
			}
		}

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_GetValueToDisplay_Internal_Virtual_String_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_GetListItemToDisplay_Internal_Virtual_String_T_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_T_0;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_T_0;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_T_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_set_index_Public_set_Void_Int32_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_AddMenuItems_Internal_Virtual_Void_IGenericMenu_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_ChangeValueFromMenu_Private_Void_T_0;

		// Token: 0x040008C1 RID: 2241
		public const int kPopupFieldDefaultIndex = -1;

		// Token: 0x020003AF RID: 943
		[ObfuscatedName("UnityEngine.UIElements.PopupField`1+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Object
		{
			// Token: 0x06003912 RID: 14610 RVA: 0x000E84E8 File Offset: 0x000E66E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<PopupField<T>.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PopupField<T>>.NativeClassPtr, "<>c__DisplayClass26_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PopupField<T>.__c__DisplayClass26_0>.NativeClassPtr);
				PopupField<T>.__c__DisplayClass26_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupField<T>.__c__DisplayClass26_0>.NativeClassPtr, "item");
				PopupField<T>.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PopupField<T>.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				PopupField<T>.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupField<T>.__c__DisplayClass26_0>.NativeClassPtr, 100665114);
				PopupField<T>.__c__DisplayClass26_0.NativeMethodInfoPtr__AddMenuItems_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PopupField<T>.__c__DisplayClass26_0>.NativeClassPtr, 100665115);
			}

			// Token: 0x06003913 RID: 14611 RVA: 0x000E85A0 File Offset: 0x000E67A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PopupField<T>.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupField<T>.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003914 RID: 14612 RVA: 0x000E85DC File Offset: 0x000E67DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302671, XrefRangeEnd = 302677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddMenuItems_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PopupField<T>.__c__DisplayClass26_0.NativeMethodInfoPtr__AddMenuItems_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003915 RID: 14613 RVA: 0x00017E18 File Offset: 0x00016018
			public __c__DisplayClass26_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700118E RID: 4494
			// (get) Token: 0x06003916 RID: 14614 RVA: 0x000E8610 File Offset: 0x000E6810
			// (set) Token: 0x06003917 RID: 14615 RVA: 0x000E8638 File Offset: 0x000E6838
			public unsafe T item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupField<T>.__c__DisplayClass26_0.NativeFieldInfoPtr_item);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupField<T>.__c__DisplayClass26_0.NativeFieldInfoPtr_item);
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

			// Token: 0x1700118F RID: 4495
			// (get) Token: 0x06003918 RID: 14616 RVA: 0x000E86E0 File Offset: 0x000E68E0
			// (set) Token: 0x06003919 RID: 14617 RVA: 0x00017E21 File Offset: 0x00016021
			public unsafe PopupField<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupField<T>.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PopupField<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PopupField<T>.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002872 RID: 10354
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04002873 RID: 10355
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002874 RID: 10356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002875 RID: 10357
			private static readonly IntPtr NativeMethodInfoPtr__AddMenuItems_b__0_Internal_Void_0;
		}
	}
}
