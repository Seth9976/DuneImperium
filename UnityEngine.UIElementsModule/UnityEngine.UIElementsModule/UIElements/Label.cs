using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200006E RID: 110
	public class Label : TextElement
	{
		// Token: 0x06000A47 RID: 2631 RVA: 0x000412E0 File Offset: 0x0003F4E0
		// Note: this type is marked as 'beforefieldinit'.
		static Label()
		{
			Il2CppClassPointerStore<Label>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Label");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Label>.NativeClassPtr);
			Label.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Label>.NativeClassPtr, "ussClassName");
			Label.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Label>.NativeClassPtr, 100664784);
			Label.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Label>.NativeClassPtr, 100664785);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0004134C File Offset: 0x0003F54C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 299393, RefRangeEnd = 299409, XrefRangeStart = 299382, XrefRangeEnd = 299393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Label()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Label>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Label.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00041388 File Offset: 0x0003F588
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 299418, RefRangeEnd = 299429, XrefRangeStart = 299409, XrefRangeEnd = 299418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Label(string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Label>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Label.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00005B67 File Offset: 0x00003D67
		public Label(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x000413D4 File Offset: 0x0003F5D4
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x00005B70 File Offset: 0x00003D70
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Label.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Label.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0200038F RID: 911
		public new class UxmlFactory : UxmlFactory<Label, Label.UxmlTraits>
		{
			// Token: 0x0600386A RID: 14442 RVA: 0x000176F4 File Offset: 0x000158F4
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Label.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Label>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Label.UxmlFactory>.NativeClassPtr);
				Label.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Label.UxmlFactory>.NativeClassPtr, 100664787);
			}

			// Token: 0x0600386B RID: 14443 RVA: 0x000E66A4 File Offset: 0x000E48A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 299380, RefRangeEnd = 299381, XrefRangeStart = 299377, XrefRangeEnd = 299380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Label.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Label.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600386C RID: 14444 RVA: 0x00017728 File Offset: 0x00015928
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002818 RID: 10264
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000390 RID: 912
		public new class UxmlTraits : TextElement.UxmlTraits
		{
			// Token: 0x0600386D RID: 14445 RVA: 0x00017731 File Offset: 0x00015931
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<Label.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Label>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Label.UxmlTraits>.NativeClassPtr);
				Label.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Label.UxmlTraits>.NativeClassPtr, 100664788);
			}

			// Token: 0x0600386E RID: 14446 RVA: 0x000E66E0 File Offset: 0x000E48E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299381, XrefRangeEnd = 299382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Label.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Label.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600386F RID: 14447 RVA: 0x00017765 File Offset: 0x00015965
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002819 RID: 10265
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
