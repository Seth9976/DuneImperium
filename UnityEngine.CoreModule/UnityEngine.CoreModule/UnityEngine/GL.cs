using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000093 RID: 147
	public sealed class GL : Object
	{
		// Token: 0x06000911 RID: 2321 RVA: 0x00033780 File Offset: 0x00031980
		// Note: this type is marked as 'beforefieldinit'.
		static GL()
		{
			Il2CppClassPointerStore<GL>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GL");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GL>.NativeClassPtr);
			GL.NativeMethodInfoPtr_Vertex3_Public_Static_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664326);
			GL.NativeMethodInfoPtr_TexCoord3_Public_Static_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664327);
			GL.NativeMethodInfoPtr_TexCoord2_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664328);
			GL.NativeMethodInfoPtr_ImmediateColor_Private_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664329);
			GL.NativeMethodInfoPtr_Color_Public_Static_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664330);
			GL.NativeMethodInfoPtr_get_wireframe_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664331);
			GL.NativeMethodInfoPtr_set_wireframe_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664332);
			GL.NativeMethodInfoPtr_SetViewMatrix_Private_Static_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664333);
			GL.NativeMethodInfoPtr_set_modelview_Public_Static_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664334);
			GL.NativeMethodInfoPtr_PushMatrix_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664335);
			GL.NativeMethodInfoPtr_PopMatrix_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664336);
			GL.NativeMethodInfoPtr_LoadOrtho_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664337);
			GL.NativeMethodInfoPtr_LoadProjectionMatrix_Public_Static_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664338);
			GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664339);
			GL.NativeMethodInfoPtr_GLLoadPixelMatrixScript_Private_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664340);
			GL.NativeMethodInfoPtr_LoadPixelMatrix_Public_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664341);
			GL.NativeMethodInfoPtr_Begin_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664342);
			GL.NativeMethodInfoPtr_End_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664343);
			GL.NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664344);
			GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664345);
			GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664346);
			GL.NativeMethodInfoPtr_Viewport_Public_Static_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664347);
			GL.NativeMethodInfoPtr_SetViewMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664348);
			GL.NativeMethodInfoPtr_LoadProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664349);
			GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664350);
			GL.NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664351);
			GL.NativeMethodInfoPtr_Viewport_Injected_Private_Static_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664352);
			GL.VerticesDelegateField = IL2CPP.ResolveICall<GL.VerticesDelegate>("UnityEngine.GL::Vertices");
			GL.MultiTexCoord3DelegateField = IL2CPP.ResolveICall<GL.MultiTexCoord3Delegate>("UnityEngine.GL::MultiTexCoord3");
			GL.get_sRGBWriteDelegateField = IL2CPP.ResolveICall<GL.get_sRGBWriteDelegate>("UnityEngine.GL::get_sRGBWrite");
			GL.set_sRGBWriteDelegateField = IL2CPP.ResolveICall<GL.set_sRGBWriteDelegate>("UnityEngine.GL::set_sRGBWrite");
			GL.get_invertCullingDelegateField = IL2CPP.ResolveICall<GL.get_invertCullingDelegate>("UnityEngine.GL::get_invertCulling");
			GL.set_invertCullingDelegateField = IL2CPP.ResolveICall<GL.set_invertCullingDelegate>("UnityEngine.GL::set_invertCulling");
			GL.FlushDelegateField = IL2CPP.ResolveICall<GL.FlushDelegate>("UnityEngine.GL::Flush");
			GL.RenderTargetBarrierDelegateField = IL2CPP.ResolveICall<GL.RenderTargetBarrierDelegate>("UnityEngine.GL::RenderTargetBarrier");
			GL.IssuePluginEventDelegateField = IL2CPP.ResolveICall<GL.IssuePluginEventDelegate>("UnityEngine.GL::IssuePluginEvent");
			GL.SetRevertBackfacingDelegateField = IL2CPP.ResolveICall<GL.SetRevertBackfacingDelegate>("UnityEngine.GL::SetRevertBackfacing");
			GL.LoadIdentityDelegateField = IL2CPP.ResolveICall<GL.LoadIdentityDelegate>("UnityEngine.GL::LoadIdentity");
			GL.LoadPixelMatrixDelegateField = IL2CPP.ResolveICall<GL.LoadPixelMatrixDelegate>("UnityEngine.GL::LoadPixelMatrix");
			GL.InvalidateStateDelegateField = IL2CPP.ResolveICall<GL.InvalidateStateDelegate>("UnityEngine.GL::InvalidateState");
			GL.GLIssuePluginEventDelegateField = IL2CPP.ResolveICall<GL.GLIssuePluginEventDelegate>("UnityEngine.GL::GLIssuePluginEvent");
			GL.ClearWithSkyboxDelegateField = IL2CPP.ResolveICall<GL.ClearWithSkyboxDelegate>("UnityEngine.GL::ClearWithSkybox");
			GL.GetWorldViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.GetWorldViewMatrix_InjectedDelegate>("UnityEngine.GL::GetWorldViewMatrix_Injected");
			GL.MultMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.MultMatrix_InjectedDelegate>("UnityEngine.GL::MultMatrix_Injected");
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00033ACC File Offset: 0x00031CCC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 649836, RefRangeEnd = 649844, XrefRangeStart = 649834, XrefRangeEnd = 649836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Vertex3(float x, float y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Vertex3_Public_Static_Void_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00033B1C File Offset: 0x00031D1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 649846, RefRangeEnd = 649850, XrefRangeStart = 649844, XrefRangeEnd = 649846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TexCoord3(float x, float y, float z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_TexCoord3_Public_Static_Void_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00033B6C File Offset: 0x00031D6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 649852, RefRangeEnd = 649856, XrefRangeStart = 649850, XrefRangeEnd = 649852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TexCoord2(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_TexCoord2_Public_Static_Void_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00033BAC File Offset: 0x00031DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649856, XrefRangeEnd = 649858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ImmediateColor(float r, float g, float b, float a)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_ImmediateColor_Private_Static_Void_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00033C08 File Offset: 0x00031E08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 649860, RefRangeEnd = 649864, XrefRangeStart = 649858, XrefRangeEnd = 649860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Color(Color c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Color_Public_Static_Void_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00033C3C File Offset: 0x00031E3C
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00033C6C File Offset: 0x00031E6C
		public unsafe static bool wireframe
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 649866, RefRangeEnd = 649868, XrefRangeStart = 649864, XrefRangeEnd = 649866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_get_wireframe_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 649870, RefRangeEnd = 649875, XrefRangeStart = 649868, XrefRangeEnd = 649870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_set_wireframe_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00033CA0 File Offset: 0x00031EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649875, XrefRangeEnd = 649877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetViewMatrix(Matrix4x4 m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_SetViewMatrix_Private_Static_Void_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x000341B0 File Offset: 0x000323B0
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x00033CD4 File Offset: 0x00031ED4
		public unsafe static Matrix4x4 modelview
		{
			get
			{
				return GL.GetWorldViewMatrix();
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 649879, RefRangeEnd = 649881, XrefRangeStart = 649877, XrefRangeEnd = 649879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_set_modelview_Public_Static_set_Void_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00033D08 File Offset: 0x00031F08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649883, RefRangeEnd = 649884, XrefRangeStart = 649881, XrefRangeEnd = 649883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PushMatrix()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_PushMatrix_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00033D30 File Offset: 0x00031F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649886, RefRangeEnd = 649887, XrefRangeStart = 649884, XrefRangeEnd = 649886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PopMatrix()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_PopMatrix_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00033D58 File Offset: 0x00031F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649889, RefRangeEnd = 649890, XrefRangeStart = 649887, XrefRangeEnd = 649889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadOrtho()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_LoadOrtho_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00033D80 File Offset: 0x00031F80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 649892, RefRangeEnd = 649894, XrefRangeStart = 649890, XrefRangeEnd = 649892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadProjectionMatrix(Matrix4x4 mat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_LoadProjectionMatrix_Public_Static_Void_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00033DB4 File Offset: 0x00031FB4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 649896, RefRangeEnd = 649909, XrefRangeStart = 649894, XrefRangeEnd = 649896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref proj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderIntoTexture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00033E00 File Offset: 0x00032000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649911, RefRangeEnd = 649912, XrefRangeStart = 649909, XrefRangeEnd = 649911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GLLoadPixelMatrixScript_Private_Static_Void_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00033E5C File Offset: 0x0003205C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649911, RefRangeEnd = 649912, XrefRangeStart = 649911, XrefRangeEnd = 649912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadPixelMatrix(float left, float right, float bottom, float top)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_LoadPixelMatrix_Public_Static_Void_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00033EB8 File Offset: 0x000320B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 649914, RefRangeEnd = 649916, XrefRangeStart = 649912, XrefRangeEnd = 649914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Begin(int mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Begin_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00033EEC File Offset: 0x000320EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 649918, RefRangeEnd = 649920, XrefRangeStart = 649916, XrefRangeEnd = 649918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void End()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_End_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00033F14 File Offset: 0x00032114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649920, XrefRangeEnd = 649922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backgroundColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00033F70 File Offset: 0x00032170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 649924, RefRangeEnd = 649926, XrefRangeStart = 649922, XrefRangeEnd = 649924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backgroundColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00033FCC File Offset: 0x000321CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649928, RefRangeEnd = 649929, XrefRangeStart = 649926, XrefRangeEnd = 649928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Clear(bool clearDepth, bool clearColor, Color backgroundColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref backgroundColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0003401C File Offset: 0x0003221C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 649931, RefRangeEnd = 649934, XrefRangeStart = 649929, XrefRangeEnd = 649931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Viewport(Rect pixelRect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pixelRect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Viewport_Public_Static_Void_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00034050 File Offset: 0x00032250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649934, XrefRangeEnd = 649936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetViewMatrix_Injected(ref Matrix4x4 m)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &m;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_SetViewMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00034084 File Offset: 0x00032284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649936, XrefRangeEnd = 649938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &mat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_LoadProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x000340B8 File Offset: 0x000322B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649938, XrefRangeEnd = 649940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &proj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref renderIntoTexture;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00034108 File Offset: 0x00032308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649940, XrefRangeEnd = 649942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearDepth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &backgroundColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00034164 File Offset: 0x00032364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649942, XrefRangeEnd = 649944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Viewport_Injected(ref Rect pixelRect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pixelRect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Viewport_Injected_Private_Static_Void_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000056F3 File Offset: 0x000038F3
		public GL(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000056FC File Offset: 0x000038FC
		public static void Vertex(Vector3 v)
		{
			GL.Vertex3(v.x, v.y, v.z);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00005717 File Offset: 0x00003917
		public unsafe static void Vertices(Vector3* v, Vector3* coords, Vector4* colors, int length)
		{
			GL.VerticesDelegateField(v, coords, colors, length);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00005727 File Offset: 0x00003927
		public static void TexCoord(Vector3 v)
		{
			GL.TexCoord3(v.x, v.y, v.z);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00005742 File Offset: 0x00003942
		public static void MultiTexCoord3(int unit, float x, float y, float z)
		{
			GL.MultiTexCoord3DelegateField(unit, x, y, z);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00005752 File Offset: 0x00003952
		public static void MultiTexCoord(int unit, Vector3 v)
		{
			GL.MultiTexCoord3(unit, v.x, v.y, v.z);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0000576E File Offset: 0x0000396E
		public static void MultiTexCoord2(int unit, float x, float y)
		{
			GL.MultiTexCoord3(unit, x, y, 0f);
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0000577F File Offset: 0x0000397F
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x0000578B File Offset: 0x0000398B
		public static bool sRGBWrite
		{
			get
			{
				return GL.get_sRGBWriteDelegateField();
			}
			set
			{
				GL.set_sRGBWriteDelegateField(value);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00005798 File Offset: 0x00003998
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x000057A4 File Offset: 0x000039A4
		public static bool invertCulling
		{
			get
			{
				return GL.get_invertCullingDelegateField();
			}
			set
			{
				GL.set_invertCullingDelegateField(value);
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000057B1 File Offset: 0x000039B1
		public static void Flush()
		{
			GL.FlushDelegateField();
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000057BD File Offset: 0x000039BD
		public static void RenderTargetBarrier()
		{
			GL.RenderTargetBarrierDelegateField();
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00034198 File Offset: 0x00032398
		public static Matrix4x4 GetWorldViewMatrix()
		{
			Matrix4x4 matrix4x;
			GL.GetWorldViewMatrix_Injected(out matrix4x);
			return matrix4x;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000057C9 File Offset: 0x000039C9
		public static void MultMatrix(Matrix4x4 m)
		{
			GL.MultMatrix_Injected(ref m);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x000057D2 File Offset: 0x000039D2
		public static void IssuePluginEvent(int eventID)
		{
			GL.IssuePluginEventDelegateField(eventID);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000057DF File Offset: 0x000039DF
		public static void SetRevertBackfacing(bool revertBackFaces)
		{
			GL.SetRevertBackfacingDelegateField(revertBackFaces);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000057EC File Offset: 0x000039EC
		public static void LoadIdentity()
		{
			GL.LoadIdentityDelegateField();
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x000057F8 File Offset: 0x000039F8
		public static void LoadPixelMatrix()
		{
			GL.LoadPixelMatrixDelegateField();
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00005804 File Offset: 0x00003A04
		public static void InvalidateState()
		{
			GL.InvalidateStateDelegateField();
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00005810 File Offset: 0x00003A10
		public static void GLIssuePluginEvent(IntPtr callback, int eventID)
		{
			GL.GLIssuePluginEventDelegateField(callback, eventID);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x000341C8 File Offset: 0x000323C8
		public static void IssuePluginEvent(IntPtr callback, int eventID)
		{
			bool flag = callback == IntPtr.Zero;
			if (flag)
			{
				throw new ArgumentException("Null callback specified.", "callback");
			}
			GL.GLIssuePluginEvent(callback, eventID);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0000581E File Offset: 0x00003A1E
		public static void ClearWithSkybox(bool clearDepth, Camera camera)
		{
			GL.ClearWithSkyboxDelegateField(clearDepth, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00005831 File Offset: 0x00003A31
		public static void GetWorldViewMatrix_Injected(out Matrix4x4 ret)
		{
			GL.GetWorldViewMatrix_InjectedDelegateField(out ret);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0000583E File Offset: 0x00003A3E
		public static void MultMatrix_Injected(ref Matrix4x4 m)
		{
			GL.MultMatrix_InjectedDelegateField(ref m);
		}

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_Vertex3_Public_Static_Void_Single_Single_Single_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_TexCoord3_Public_Static_Void_Single_Single_Single_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_TexCoord2_Public_Static_Void_Single_Single_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_ImmediateColor_Private_Static_Void_Single_Single_Single_Single_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_Color_Public_Static_Void_Color_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_get_wireframe_Public_Static_get_Boolean_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_set_wireframe_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_SetViewMatrix_Private_Static_Void_Matrix4x4_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_set_modelview_Public_Static_set_Void_Matrix4x4_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_PushMatrix_Public_Static_Void_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_PopMatrix_Public_Static_Void_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_LoadOrtho_Public_Static_Void_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_LoadProjectionMatrix_Public_Static_Void_Matrix4x4_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_GLLoadPixelMatrixScript_Private_Static_Void_Single_Single_Single_Single_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_LoadPixelMatrix_Public_Static_Void_Single_Single_Single_Single_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Static_Void_Int32_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Static_Void_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_Single_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_Viewport_Public_Static_Void_Rect_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_SetViewMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_LoadProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_Viewport_Injected_Private_Static_Void_byref_Rect_0;

		// Token: 0x04000715 RID: 1813
		public const int TRIANGLES = 4;

		// Token: 0x04000716 RID: 1814
		public const int TRIANGLE_STRIP = 5;

		// Token: 0x04000717 RID: 1815
		public const int QUADS = 7;

		// Token: 0x04000718 RID: 1816
		public const int LINES = 1;

		// Token: 0x04000719 RID: 1817
		public const int LINE_STRIP = 2;

		// Token: 0x0400071A RID: 1818
		private static readonly GL.VerticesDelegate VerticesDelegateField;

		// Token: 0x0400071B RID: 1819
		private static readonly GL.MultiTexCoord3Delegate MultiTexCoord3DelegateField;

		// Token: 0x0400071C RID: 1820
		private static readonly GL.get_sRGBWriteDelegate get_sRGBWriteDelegateField;

		// Token: 0x0400071D RID: 1821
		private static readonly GL.set_sRGBWriteDelegate set_sRGBWriteDelegateField;

		// Token: 0x0400071E RID: 1822
		private static readonly GL.get_invertCullingDelegate get_invertCullingDelegateField;

		// Token: 0x0400071F RID: 1823
		private static readonly GL.set_invertCullingDelegate set_invertCullingDelegateField;

		// Token: 0x04000720 RID: 1824
		private static readonly GL.FlushDelegate FlushDelegateField;

		// Token: 0x04000721 RID: 1825
		private static readonly GL.RenderTargetBarrierDelegate RenderTargetBarrierDelegateField;

		// Token: 0x04000722 RID: 1826
		private static readonly GL.IssuePluginEventDelegate IssuePluginEventDelegateField;

		// Token: 0x04000723 RID: 1827
		private static readonly GL.SetRevertBackfacingDelegate SetRevertBackfacingDelegateField;

		// Token: 0x04000724 RID: 1828
		private static readonly GL.LoadIdentityDelegate LoadIdentityDelegateField;

		// Token: 0x04000725 RID: 1829
		private static readonly GL.LoadPixelMatrixDelegate LoadPixelMatrixDelegateField;

		// Token: 0x04000726 RID: 1830
		private static readonly GL.InvalidateStateDelegate InvalidateStateDelegateField;

		// Token: 0x04000727 RID: 1831
		private static readonly GL.GLIssuePluginEventDelegate GLIssuePluginEventDelegateField;

		// Token: 0x04000728 RID: 1832
		private static readonly GL.ClearWithSkyboxDelegate ClearWithSkyboxDelegateField;

		// Token: 0x04000729 RID: 1833
		private static readonly GL.GetWorldViewMatrix_InjectedDelegate GetWorldViewMatrix_InjectedDelegateField;

		// Token: 0x0400072A RID: 1834
		private static readonly GL.MultMatrix_InjectedDelegate MultMatrix_InjectedDelegateField;

		// Token: 0x020004FC RID: 1276
		// (Invoke) Token: 0x06003309 RID: 13065
		private delegate void VerticesDelegate(IntPtr v, IntPtr coords, IntPtr colors, int length);

		// Token: 0x020004FD RID: 1277
		// (Invoke) Token: 0x0600330B RID: 13067
		private delegate void MultiTexCoord3Delegate(int unit, float x, float y, float z);

		// Token: 0x020004FE RID: 1278
		// (Invoke) Token: 0x0600330D RID: 13069
		private delegate bool get_sRGBWriteDelegate();

		// Token: 0x020004FF RID: 1279
		// (Invoke) Token: 0x0600330F RID: 13071
		private delegate void set_sRGBWriteDelegate(bool value);

		// Token: 0x02000500 RID: 1280
		// (Invoke) Token: 0x06003311 RID: 13073
		private delegate bool get_invertCullingDelegate();

		// Token: 0x02000501 RID: 1281
		// (Invoke) Token: 0x06003313 RID: 13075
		private delegate void set_invertCullingDelegate(bool value);

		// Token: 0x02000502 RID: 1282
		// (Invoke) Token: 0x06003315 RID: 13077
		private delegate void FlushDelegate();

		// Token: 0x02000503 RID: 1283
		// (Invoke) Token: 0x06003317 RID: 13079
		private delegate void RenderTargetBarrierDelegate();

		// Token: 0x02000504 RID: 1284
		// (Invoke) Token: 0x06003319 RID: 13081
		private delegate void IssuePluginEventDelegate(int eventID);

		// Token: 0x02000505 RID: 1285
		// (Invoke) Token: 0x0600331B RID: 13083
		private delegate void SetRevertBackfacingDelegate(bool revertBackFaces);

		// Token: 0x02000506 RID: 1286
		// (Invoke) Token: 0x0600331D RID: 13085
		private delegate void LoadIdentityDelegate();

		// Token: 0x02000507 RID: 1287
		// (Invoke) Token: 0x0600331F RID: 13087
		private delegate void LoadPixelMatrixDelegate();

		// Token: 0x02000508 RID: 1288
		// (Invoke) Token: 0x06003321 RID: 13089
		private delegate void InvalidateStateDelegate();

		// Token: 0x02000509 RID: 1289
		// (Invoke) Token: 0x06003323 RID: 13091
		private delegate void GLIssuePluginEventDelegate(IntPtr callback, int eventID);

		// Token: 0x0200050A RID: 1290
		// (Invoke) Token: 0x06003325 RID: 13093
		private delegate void ClearWithSkyboxDelegate(bool clearDepth, IntPtr camera);

		// Token: 0x0200050B RID: 1291
		// (Invoke) Token: 0x06003327 RID: 13095
		private delegate void GetWorldViewMatrix_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200050C RID: 1292
		// (Invoke) Token: 0x06003329 RID: 13097
		private delegate void MultMatrix_InjectedDelegate(IntPtr m);
	}
}
