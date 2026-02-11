using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F7 RID: 503
	public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription<string>
	{
		// Token: 0x0600279D RID: 10141 RVA: 0x000AE6D4 File Offset: 0x000AC8D4
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlStringAttributeDescription()
		{
			Il2CppClassPointerStore<UxmlStringAttributeDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlStringAttributeDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlStringAttributeDescription>.NativeClassPtr);
			UxmlStringAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlStringAttributeDescription>.NativeClassPtr, 100669244);
			UxmlStringAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_String_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlStringAttributeDescription>.NativeClassPtr, 100669245);
			UxmlStringAttributeDescription.NativeMethodInfoPtr_TryGetValueFromBag_Public_Boolean_IUxmlAttributes_CreationContext_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlStringAttributeDescription>.NativeClassPtr, 100669246);
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x000AE740 File Offset: 0x000AC940
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 343279, RefRangeEnd = 343319, XrefRangeStart = 343266, XrefRangeEnd = 343279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlStringAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlStringAttributeDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlStringAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x000AE77C File Offset: 0x000AC97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343319, XrefRangeEnd = 343338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlStringAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_String_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x000AE7E8 File Offset: 0x000AC9E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343357, RefRangeEnd = 343359, XrefRangeStart = 343338, XrefRangeEnd = 343357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UxmlStringAttributeDescription.NativeMethodInfoPtr_TryGetValueFromBag_Public_Boolean_IUxmlAttributes_CreationContext_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x00010199 File Offset: 0x0000E399
		public UxmlStringAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x000AE870 File Offset: 0x000ACA70
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue;
			}
		}

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_String_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValueFromBag_Public_Boolean_IUxmlAttributes_CreationContext_byref_String_0;

		// Token: 0x02000503 RID: 1283
		[ObfuscatedName("UnityEngine.UIElements.UxmlStringAttributeDescription+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003FA8 RID: 16296 RVA: 0x000FD864 File Offset: 0x000FBA64
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UxmlStringAttributeDescription.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UxmlStringAttributeDescription>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlStringAttributeDescription.__c>.NativeClassPtr);
				UxmlStringAttributeDescription.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlStringAttributeDescription.__c>.NativeClassPtr, "<>9");
				UxmlStringAttributeDescription.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlStringAttributeDescription.__c>.NativeClassPtr, "<>9__3_0");
				UxmlStringAttributeDescription.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlStringAttributeDescription.__c>.NativeClassPtr, "<>9__4_0");
				UxmlStringAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlStringAttributeDescription.__c>.NativeClassPtr, 100669248);
				UxmlStringAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlStringAttributeDescription.__c>.NativeClassPtr, 100669249);
				UxmlStringAttributeDescription.__c.NativeMethodInfoPtr__TryGetValueFromBag_b__4_0_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlStringAttributeDescription.__c>.NativeClassPtr, 100669250);
			}

			// Token: 0x06003FA9 RID: 16297 RVA: 0x000FD908 File Offset: 0x000FBB08
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlStringAttributeDescription.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlStringAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003FAA RID: 16298 RVA: 0x000FD944 File Offset: 0x000FBB44
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetValueFromBag_b__3_0(string s, string t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlStringAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06003FAB RID: 16299 RVA: 0x000FD9A0 File Offset: 0x000FBBA0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _TryGetValueFromBag_b__4_0(string s, string t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlStringAttributeDescription.__c.NativeMethodInfoPtr__TryGetValueFromBag_b__4_0_Internal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06003FAC RID: 16300 RVA: 0x0001AB37 File Offset: 0x00018D37
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001312 RID: 4882
			// (get) Token: 0x06003FAD RID: 16301 RVA: 0x000FD9FC File Offset: 0x000FBBFC
			// (set) Token: 0x06003FAE RID: 16302 RVA: 0x0001AB40 File Offset: 0x00018D40
			public unsafe static UxmlStringAttributeDescription.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlStringAttributeDescription.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlStringAttributeDescription.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001313 RID: 4883
			// (get) Token: 0x06003FAF RID: 16303 RVA: 0x000FDA24 File Offset: 0x000FBC24
			// (set) Token: 0x06003FB0 RID: 16304 RVA: 0x0001AB52 File Offset: 0x00018D52
			public unsafe static Func<string, string, string> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlStringAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlStringAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001314 RID: 4884
			// (get) Token: 0x06003FB1 RID: 16305 RVA: 0x000FDA4C File Offset: 0x000FBC4C
			// (set) Token: 0x06003FB2 RID: 16306 RVA: 0x0001AB64 File Offset: 0x00018D64
			public unsafe static Func<string, string, string> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlStringAttributeDescription.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlStringAttributeDescription.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CF7 RID: 11511
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002CF8 RID: 11512
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002CF9 RID: 11513
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04002CFA RID: 11514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002CFB RID: 11515
			private static readonly IntPtr NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_String_String_String_0;

			// Token: 0x04002CFC RID: 11516
			private static readonly IntPtr NativeMethodInfoPtr__TryGetValueFromBag_b__4_0_Internal_String_String_String_0;
		}

		// Token: 0x02000504 RID: 1284
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
