using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FB RID: 251
	public class Gradient : Object
	{
		// Token: 0x0600138C RID: 5004 RVA: 0x00061C5C File Offset: 0x0005FE5C
		// Note: this type is marked as 'beforefieldinit'.
		static Gradient()
		{
			Il2CppClassPointerStore<Gradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Gradient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gradient>.NativeClassPtr);
			Gradient.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "m_Ptr");
			Gradient.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100666053);
			Gradient.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100666054);
			Gradient.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100666055);
			Gradient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100666056);
			Gradient.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100666057);
			Gradient.NativeMethodInfoPtr_Evaluate_Public_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100666058);
			Gradient.NativeMethodInfoPtr_SetKeys_Public_Void_Il2CppStructArray_1_GradientColorKey_Il2CppStructArray_1_GradientAlphaKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100666059);
			Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100666060);
			Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100666061);
			Gradient.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100666062);
			Gradient.NativeMethodInfoPtr_Evaluate_Injected_Private_Void_Single_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100666063);
			Gradient.get_colorKeysDelegateField = IL2CPP.ResolveICall<Gradient.get_colorKeysDelegate>("UnityEngine.Gradient::get_colorKeys");
			Gradient.set_colorKeysDelegateField = IL2CPP.ResolveICall<Gradient.set_colorKeysDelegate>("UnityEngine.Gradient::set_colorKeys");
			Gradient.get_alphaKeysDelegateField = IL2CPP.ResolveICall<Gradient.get_alphaKeysDelegate>("UnityEngine.Gradient::get_alphaKeys");
			Gradient.set_alphaKeysDelegateField = IL2CPP.ResolveICall<Gradient.set_alphaKeysDelegate>("UnityEngine.Gradient::set_alphaKeys");
			Gradient.get_modeDelegateField = IL2CPP.ResolveICall<Gradient.get_modeDelegate>("UnityEngine.Gradient::get_mode");
			Gradient.set_modeDelegateField = IL2CPP.ResolveICall<Gradient.set_modeDelegate>("UnityEngine.Gradient::set_mode");
			Gradient.get_colorSpaceDelegateField = IL2CPP.ResolveICall<Gradient.get_colorSpaceDelegate>("UnityEngine.Gradient::get_colorSpace");
			Gradient.set_colorSpaceDelegateField = IL2CPP.ResolveICall<Gradient.set_colorSpaceDelegate>("UnityEngine.Gradient::set_colorSpace");
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00061DF4 File Offset: 0x0005FFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658284, XrefRangeEnd = 658286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00061E24 File Offset: 0x00060024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658286, XrefRangeEnd = 658288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00061E58 File Offset: 0x00060058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658288, XrefRangeEnd = 658290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Internal_Equals(IntPtr other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00061EA4 File Offset: 0x000600A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 658293, RefRangeEnd = 658294, XrefRangeStart = 658290, XrefRangeEnd = 658293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gradient()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gradient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00061EE0 File Offset: 0x000600E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658294, XrefRangeEnd = 658299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gradient.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00061F1C File Offset: 0x0006011C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 658301, RefRangeEnd = 658304, XrefRangeStart = 658299, XrefRangeEnd = 658301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color Evaluate(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Evaluate_Public_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00061F68 File Offset: 0x00060168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 658306, RefRangeEnd = 658307, XrefRangeStart = 658304, XrefRangeEnd = 658306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetKeys(Il2CppStructArray<GradientColorKey> colorKeys, Il2CppStructArray<GradientAlphaKey> alphaKeys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorKeys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alphaKeys);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_SetKeys_Public_Void_Il2CppStructArray_1_GradientColorKey_Il2CppStructArray_1_GradientAlphaKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00061FBC File Offset: 0x000601BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658307, XrefRangeEnd = 658321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00062014 File Offset: 0x00060214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658321, XrefRangeEnd = 658327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Gradient other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00062064 File Offset: 0x00060264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658327, XrefRangeEnd = 658328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Gradient.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x000620AC File Offset: 0x000602AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 658328, XrefRangeEnd = 658330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate_Injected(float time, out Color ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gradient.NativeMethodInfoPtr_Evaluate_Injected_Private_Void_Single_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00008084 File Offset: 0x00006284
		public Gradient(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x000620F8 File Offset: 0x000602F8
		// (set) Token: 0x0600139A RID: 5018 RVA: 0x0000808D File Offset: 0x0000628D
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gradient.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x00062120 File Offset: 0x00060320
		// (set) Token: 0x0600139C RID: 5020 RVA: 0x000080A8 File Offset: 0x000062A8
		public Il2CppStructArray<GradientColorKey> colorKeys
		{
			get
			{
				IntPtr intPtr = Gradient.get_colorKeysDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GradientColorKey>>(intPtr2) : null;
			}
			set
			{
				Gradient.set_colorKeysDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x0006214C File Offset: 0x0006034C
		// (set) Token: 0x0600139E RID: 5022 RVA: 0x000080C0 File Offset: 0x000062C0
		public Il2CppStructArray<GradientAlphaKey> alphaKeys
		{
			get
			{
				IntPtr intPtr = Gradient.get_alphaKeysDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GradientAlphaKey>>(intPtr2) : null;
			}
			set
			{
				Gradient.set_alphaKeysDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x000080D8 File Offset: 0x000062D8
		// (set) Token: 0x060013A0 RID: 5024 RVA: 0x000080EA File Offset: 0x000062EA
		public GradientMode mode
		{
			get
			{
				return Gradient.get_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Gradient.set_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x000080FD File Offset: 0x000062FD
		// (set) Token: 0x060013A2 RID: 5026 RVA: 0x0000810F File Offset: 0x0000630F
		public ColorSpace colorSpace
		{
			get
			{
				return Gradient.get_colorSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Gradient.set_colorSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_IntPtr_0;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Color_Single_0;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeMethodInfoPtr_SetKeys_Public_Void_Il2CppStructArray_1_GradientColorKey_Il2CppStructArray_1_GradientAlphaKey_0;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Gradient_0;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Injected_Private_Void_Single_byref_Color_0;

		// Token: 0x040012A0 RID: 4768
		private static readonly Gradient.get_colorKeysDelegate get_colorKeysDelegateField;

		// Token: 0x040012A1 RID: 4769
		private static readonly Gradient.set_colorKeysDelegate set_colorKeysDelegateField;

		// Token: 0x040012A2 RID: 4770
		private static readonly Gradient.get_alphaKeysDelegate get_alphaKeysDelegateField;

		// Token: 0x040012A3 RID: 4771
		private static readonly Gradient.set_alphaKeysDelegate set_alphaKeysDelegateField;

		// Token: 0x040012A4 RID: 4772
		private static readonly Gradient.get_modeDelegate get_modeDelegateField;

		// Token: 0x040012A5 RID: 4773
		private static readonly Gradient.set_modeDelegate set_modeDelegateField;

		// Token: 0x040012A6 RID: 4774
		private static readonly Gradient.get_colorSpaceDelegate get_colorSpaceDelegateField;

		// Token: 0x040012A7 RID: 4775
		private static readonly Gradient.set_colorSpaceDelegate set_colorSpaceDelegateField;

		// Token: 0x020006DF RID: 1759
		// (Invoke) Token: 0x0600369D RID: 13981
		private delegate IntPtr get_colorKeysDelegate(IntPtr @this);

		// Token: 0x020006E0 RID: 1760
		// (Invoke) Token: 0x0600369F RID: 13983
		private delegate void set_colorKeysDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020006E1 RID: 1761
		// (Invoke) Token: 0x060036A1 RID: 13985
		private delegate IntPtr get_alphaKeysDelegate(IntPtr @this);

		// Token: 0x020006E2 RID: 1762
		// (Invoke) Token: 0x060036A3 RID: 13987
		private delegate void set_alphaKeysDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020006E3 RID: 1763
		// (Invoke) Token: 0x060036A5 RID: 13989
		private delegate GradientMode get_modeDelegate(IntPtr @this);

		// Token: 0x020006E4 RID: 1764
		// (Invoke) Token: 0x060036A7 RID: 13991
		private delegate void set_modeDelegate(IntPtr @this, GradientMode value);

		// Token: 0x020006E5 RID: 1765
		// (Invoke) Token: 0x060036A9 RID: 13993
		private delegate ColorSpace get_colorSpaceDelegate(IntPtr @this);

		// Token: 0x020006E6 RID: 1766
		// (Invoke) Token: 0x060036AB RID: 13995
		private delegate void set_colorSpaceDelegate(IntPtr @this, ColorSpace value);
	}
}
