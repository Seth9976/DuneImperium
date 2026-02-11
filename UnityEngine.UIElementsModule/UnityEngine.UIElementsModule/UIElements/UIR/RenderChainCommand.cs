using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000252 RID: 594
	public class RenderChainCommand : LinkedPoolItem<RenderChainCommand>
	{
		// Token: 0x06002BE4 RID: 11236 RVA: 0x000BD7B8 File Offset: 0x000BB9B8
		// Note: this type is marked as 'beforefieldinit'.
		static RenderChainCommand()
		{
			Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "RenderChainCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr);
			RenderChainCommand.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "owner");
			RenderChainCommand.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "prev");
			RenderChainCommand.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "next");
			RenderChainCommand.NativeFieldInfoPtr_closing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "closing");
			RenderChainCommand.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "type");
			RenderChainCommand.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "state");
			RenderChainCommand.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "mesh");
			RenderChainCommand.NativeFieldInfoPtr_indexOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "indexOffset");
			RenderChainCommand.NativeFieldInfoPtr_indexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "indexCount");
			RenderChainCommand.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "callback");
			RenderChainCommand.NativeFieldInfoPtr_k_ID_MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "k_ID_MainTex");
			RenderChainCommand.NativeFieldInfoPtr_s_ImmediateOverheadMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, "s_ImmediateOverheadMarker");
			RenderChainCommand.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, 100669812);
			RenderChainCommand.NativeMethodInfoPtr_ExecuteNonDrawMesh_Internal_Void_DrawParams_Single_byref_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, 100669813);
			RenderChainCommand.NativeMethodInfoPtr_Blit_Private_Void_Texture_RenderTexture_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, 100669814);
			RenderChainCommand.NativeMethodInfoPtr_CombineScissorRects_Private_Static_Rect_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, 100669815);
			RenderChainCommand.NativeMethodInfoPtr_RectPointsToPixelsAndFlipYAxis_Private_Static_RectInt_Rect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, 100669816);
			RenderChainCommand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr, 100669817);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x000BD950 File Offset: 0x000BBB50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 349844, RefRangeEnd = 349846, XrefRangeStart = 349830, XrefRangeEnd = 349844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChainCommand.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000BD984 File Offset: 0x000BBB84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349915, RefRangeEnd = 349916, XrefRangeStart = 349846, XrefRangeEnd = 349915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drawParams);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerPoint;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(immediateException);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RenderChainCommand.NativeMethodInfoPtr_ExecuteNonDrawMesh_Internal_Void_DrawParams_Single_byref_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			immediateException = ((intPtr4 == 0) ? null : new Exception(intPtr4));
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000BD9FC File Offset: 0x000BBBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349916, XrefRangeEnd = 349937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blit(Texture source, RenderTexture destination, float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChainCommand.NativeMethodInfoPtr_Blit_Private_Void_Texture_RenderTexture_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000BDA60 File Offset: 0x000BBC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349937, XrefRangeEnd = 349946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect CombineScissorRects(Rect r0, Rect r1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChainCommand.NativeMethodInfoPtr_CombineScissorRects_Private_Static_Rect_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000BDAAC File Offset: 0x000BBCAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 349958, RefRangeEnd = 349960, XrefRangeStart = 349946, XrefRangeEnd = 349958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChainCommand.NativeMethodInfoPtr_RectPointsToPixelsAndFlipYAxis_Private_Static_RectInt_Rect_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000BDAF8 File Offset: 0x000BBCF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349963, RefRangeEnd = 349964, XrefRangeStart = 349960, XrefRangeEnd = 349963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderChainCommand()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderChainCommand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChainCommand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x00011CA1 File Offset: 0x0000FEA1
		public RenderChainCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x000BDB34 File Offset: 0x000BBD34
		// (set) Token: 0x06002BED RID: 11245 RVA: 0x00011CAA File Offset: 0x0000FEAA
		public unsafe VisualElement owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_owner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x000BDB64 File Offset: 0x000BBD64
		// (set) Token: 0x06002BEF RID: 11247 RVA: 0x00011CC9 File Offset: 0x0000FEC9
		public unsafe RenderChainCommand prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x000BDB94 File Offset: 0x000BBD94
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		public unsafe RenderChainCommand next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x000BDBC4 File Offset: 0x000BBDC4
		// (set) Token: 0x06002BF3 RID: 11251 RVA: 0x00011D07 File Offset: 0x0000FF07
		public unsafe bool closing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_closing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_closing)) = value;
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x000BDBEC File Offset: 0x000BBDEC
		// (set) Token: 0x06002BF5 RID: 11253 RVA: 0x00011D22 File Offset: 0x0000FF22
		public unsafe CommandType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x000BDC14 File Offset: 0x000BBE14
		// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x00011D3D File Offset: 0x0000FF3D
		public State state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_state);
				return new State(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<State>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_state), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<State>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x000BDC44 File Offset: 0x000BBE44
		// (set) Token: 0x06002BF9 RID: 11257 RVA: 0x00011D6B File Offset: 0x0000FF6B
		public unsafe MeshHandle mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x000BDC74 File Offset: 0x000BBE74
		// (set) Token: 0x06002BFB RID: 11259 RVA: 0x00011D8A File Offset: 0x0000FF8A
		public unsafe int indexOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_indexOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_indexOffset)) = value;
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x000BDC9C File Offset: 0x000BBE9C
		// (set) Token: 0x06002BFD RID: 11261 RVA: 0x00011DA5 File Offset: 0x0000FFA5
		public unsafe int indexCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_indexCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_indexCount)) = value;
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06002BFE RID: 11262 RVA: 0x000BDCC4 File Offset: 0x000BBEC4
		// (set) Token: 0x06002BFF RID: 11263 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		public unsafe Action callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainCommand.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06002C00 RID: 11264 RVA: 0x000BDCF4 File Offset: 0x000BBEF4
		// (set) Token: 0x06002C01 RID: 11265 RVA: 0x00011DDF File Offset: 0x0000FFDF
		public unsafe static int k_ID_MainTex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RenderChainCommand.NativeFieldInfoPtr_k_ID_MainTex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderChainCommand.NativeFieldInfoPtr_k_ID_MainTex, (void*)(&value));
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06002C02 RID: 11266 RVA: 0x000BDD10 File Offset: 0x000BBF10
		// (set) Token: 0x06002C03 RID: 11267 RVA: 0x00011DED File Offset: 0x0000FFED
		public unsafe static ProfilerMarker s_ImmediateOverheadMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(RenderChainCommand.NativeFieldInfoPtr_s_ImmediateOverheadMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderChainCommand.NativeFieldInfoPtr_s_ImmediateOverheadMarker, (void*)(&value));
			}
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x000BDD2C File Offset: 0x000BBF2C
		public static Vector4 RectToClipSpace(Rect rc)
		{
			Matrix4x4 deviceProjectionMatrix = Utility.GetDeviceProjectionMatrix();
			Vector3 vector = deviceProjectionMatrix.MultiplyPoint(new Vector3(rc.xMin, rc.yMin, 0f));
			Vector3 vector2 = deviceProjectionMatrix.MultiplyPoint(new Vector3(rc.xMax, rc.yMax, 0f));
			return new Vector4(Mathf.Min(vector.x, vector2.x), Mathf.Min(vector.y, vector2.y), Mathf.Max(vector.x, vector2.x), Mathf.Max(vector.y, vector2.y));
		}

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeFieldInfoPtr_owner;

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeFieldInfoPtr_prev;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04001F4B RID: 8011
		private static readonly IntPtr NativeFieldInfoPtr_closing;

		// Token: 0x04001F4C RID: 8012
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001F4D RID: 8013
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001F4E RID: 8014
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x04001F4F RID: 8015
		private static readonly IntPtr NativeFieldInfoPtr_indexOffset;

		// Token: 0x04001F50 RID: 8016
		private static readonly IntPtr NativeFieldInfoPtr_indexCount;

		// Token: 0x04001F51 RID: 8017
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04001F52 RID: 8018
		private static readonly IntPtr NativeFieldInfoPtr_k_ID_MainTex;

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeFieldInfoPtr_s_ImmediateOverheadMarker;

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteNonDrawMesh_Internal_Void_DrawParams_Single_byref_Exception_0;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeMethodInfoPtr_Blit_Private_Void_Texture_RenderTexture_Single_0;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeMethodInfoPtr_CombineScissorRects_Private_Static_Rect_Rect_Rect_0;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeMethodInfoPtr_RectPointsToPixelsAndFlipYAxis_Private_Static_RectInt_Rect_Single_0;

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
