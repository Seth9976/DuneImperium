using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020001FF RID: 511
	[StructLayout(2)]
	public struct RenderTargetIdentifier
	{
		// Token: 0x060021FC RID: 8700 RVA: 0x00094DB4 File Offset: 0x00092FB4
		// Note: this type is marked as 'beforefieldinit'.
		static RenderTargetIdentifier()
		{
			Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderTargetIdentifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr);
			RenderTargetIdentifier.NativeFieldInfoPtr_AllDepthSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "AllDepthSlices");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_Type");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_NameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_NameID");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_InstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_InstanceID");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_BufferPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_BufferPointer");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_MipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_MipLevel");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_CubeFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_CubeFace");
			RenderTargetIdentifier.NativeFieldInfoPtr_m_DepthSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_DepthSlice");
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667865);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667866);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667867);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667868);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667869);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667870);
			RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667871);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667872);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667873);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667874);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667875);
			RenderTargetIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667876);
			RenderTargetIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667877);
			RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667878);
			RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667879);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667880);
			RenderTargetIdentifier.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667881);
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x00094FD8 File Offset: 0x000931D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681530, RefRangeEnd = 681531, XrefRangeStart = 681530, XrefRangeEnd = 681530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(BuiltinRenderTextureType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x0009500C File Offset: 0x0009320C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681531, XrefRangeEnd = 681532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x00095044 File Offset: 0x00093244
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 681532, RefRangeEnd = 681535, XrefRangeStart = 681532, XrefRangeEnd = 681532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00095078 File Offset: 0x00093278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681535, RefRangeEnd = 681536, XrefRangeStart = 681535, XrefRangeEnd = 681535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(int nameID, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubeFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_CubemapFace_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x000950D4 File Offset: 0x000932D4
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 681536, RefRangeEnd = 681564, XrefRangeStart = 681536, XrefRangeEnd = 681536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderTargetIdentifier;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubeFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00095130 File Offset: 0x00093330
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 681577, RefRangeEnd = 681586, XrefRangeStart = 681564, XrefRangeEnd = 681577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(Texture tex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Texture_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x00095168 File Offset: 0x00093368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681586, RefRangeEnd = 681587, XrefRangeStart = 681586, XrefRangeEnd = 681586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTargetIdentifier(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buf;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mipLevel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubeFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depthSlice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderBuffer_Int32_CubemapFace_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x000951C4 File Offset: 0x000933C4
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 681587, RefRangeEnd = 681626, XrefRangeStart = 681587, XrefRangeEnd = 681587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTargetIdentifier(BuiltinRenderTextureType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00095204 File Offset: 0x00093404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681627, RefRangeEnd = 681628, XrefRangeStart = 681626, XrefRangeEnd = 681627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTargetIdentifier(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00095248 File Offset: 0x00093448
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 681628, RefRangeEnd = 681663, XrefRangeStart = 681628, XrefRangeEnd = 681628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTargetIdentifier(int nameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x00095288 File Offset: 0x00093488
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 681676, RefRangeEnd = 681720, XrefRangeStart = 681663, XrefRangeEnd = 681676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RenderTargetIdentifier(Texture tex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x000952CC File Offset: 0x000934CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681720, XrefRangeEnd = 681758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x000952F8 File Offset: 0x000934F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 681761, RefRangeEnd = 681762, XrefRangeStart = 681758, XrefRangeEnd = 681761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x00095328 File Offset: 0x00093528
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 681763, RefRangeEnd = 681789, XrefRangeStart = 681762, XrefRangeEnd = 681763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RenderTargetIdentifier rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x00095368 File Offset: 0x00093568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681789, XrefRangeEnd = 681793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x000953AC File Offset: 0x000935AC
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 681763, RefRangeEnd = 681789, XrefRangeStart = 681763, XrefRangeEnd = 681789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x000953F8 File Offset: 0x000935F8
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 681794, RefRangeEnd = 681819, XrefRangeStart = 681793, XrefRangeEnd = 681794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x0000CF12 File Offset: 0x0000B112
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, ref this));
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x00095444 File Offset: 0x00093644
		// (set) Token: 0x06002210 RID: 8720 RVA: 0x0000CF24 File Offset: 0x0000B124
		public unsafe static int AllDepthSlices
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderTargetIdentifier.NativeFieldInfoPtr_AllDepthSlices, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderTargetIdentifier.NativeFieldInfoPtr_AllDepthSlices, (void*)(&value));
			}
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x00095460 File Offset: 0x00093660
		public static implicit operator RenderTargetIdentifier(RenderBuffer buf)
		{
			return new RenderTargetIdentifier(buf, 0, CubemapFace.Unknown, 0);
		}

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeFieldInfoPtr_AllDepthSlices;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeFieldInfoPtr_m_NameID;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceID;

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferPointer;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeFieldInfoPtr_m_MipLevel;

		// Token: 0x04001DED RID: 7661
		private static readonly IntPtr NativeFieldInfoPtr_m_CubeFace;

		// Token: 0x04001DEE RID: 7662
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthSlice;

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001DF2 RID: 7666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_CubemapFace_Int32_0;

		// Token: 0x04001DF3 RID: 7667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0;

		// Token: 0x04001DF4 RID: 7668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_0;

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderBuffer_Int32_CubemapFace_Int32_0;

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_String_0;

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0;

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0;

		// Token: 0x04001E00 RID: 7680
		[FieldOffset(0)]
		public BuiltinRenderTextureType m_Type;

		// Token: 0x04001E01 RID: 7681
		[FieldOffset(4)]
		public int m_NameID;

		// Token: 0x04001E02 RID: 7682
		[FieldOffset(8)]
		public int m_InstanceID;

		// Token: 0x04001E03 RID: 7683
		[FieldOffset(16)]
		public IntPtr m_BufferPointer;

		// Token: 0x04001E04 RID: 7684
		[FieldOffset(24)]
		public int m_MipLevel;

		// Token: 0x04001E05 RID: 7685
		[FieldOffset(28)]
		public CubemapFace m_CubeFace;

		// Token: 0x04001E06 RID: 7686
		[FieldOffset(32)]
		public int m_DepthSlice;
	}
}
