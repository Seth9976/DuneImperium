using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x020000E1 RID: 225
	[Serializable]
	public class TextureCurve : Object
	{
		// Token: 0x06001051 RID: 4177 RVA: 0x0004B564 File Offset: 0x00049764
		// Note: this type is marked as 'beforefieldinit'.
		static TextureCurve()
		{
			Il2CppClassPointerStore<TextureCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "TextureCurve");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr);
			TextureCurve.NativeFieldInfoPtr_k_Precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, "k_Precision");
			TextureCurve.NativeFieldInfoPtr_k_Step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, "k_Step");
			TextureCurve.NativeFieldInfoPtr__length_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, "<length>k__BackingField");
			TextureCurve.NativeFieldInfoPtr_m_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, "m_Loop");
			TextureCurve.NativeFieldInfoPtr_m_ZeroValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, "m_ZeroValue");
			TextureCurve.NativeFieldInfoPtr_m_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, "m_Range");
			TextureCurve.NativeFieldInfoPtr_m_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, "m_Curve");
			TextureCurve.NativeFieldInfoPtr_m_LoopingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, "m_LoopingCurve");
			TextureCurve.NativeFieldInfoPtr_m_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, "m_Texture");
			TextureCurve.NativeFieldInfoPtr_m_IsCurveDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, "m_IsCurveDirty");
			TextureCurve.NativeFieldInfoPtr_m_IsTextureDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, "m_IsTextureDirty");
			TextureCurve.NativeMethodInfoPtr_get_length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665717);
			TextureCurve.NativeMethodInfoPtr_set_length_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665718);
			TextureCurve.NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665719);
			TextureCurve.NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_Single_Boolean_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665720);
			TextureCurve.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_Single_Boolean_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665721);
			TextureCurve.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665722);
			TextureCurve.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665723);
			TextureCurve.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665724);
			TextureCurve.NativeMethodInfoPtr_SetDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665725);
			TextureCurve.NativeMethodInfoPtr_GetTextureFormat_Private_Static_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665726);
			TextureCurve.NativeMethodInfoPtr_GetTexture_Public_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665727);
			TextureCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665728);
			TextureCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665729);
			TextureCurve.NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665730);
			TextureCurve.NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665731);
			TextureCurve.NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr, 100665732);
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x0004B7B0 File Offset: 0x000499B0
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x0004B7EC File Offset: 0x000499EC
		public unsafe int length
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr_get_length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr_set_length_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DD RID: 1245
		public unsafe Keyframe this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977687, XrefRangeEnd = 977688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0004B878 File Offset: 0x00049A78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 977700, RefRangeEnd = 977701, XrefRangeStart = 977688, XrefRangeEnd = 977700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureCurve(AnimationCurve baseCurve, float zeroValue, bool loop, [In] ref Vector2 bounds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseCurve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_Single_Boolean_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0004B8F0 File Offset: 0x00049AF0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 977712, RefRangeEnd = 977720, XrefRangeStart = 977701, XrefRangeEnd = 977712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureCurve(Il2CppStructArray<Keyframe> keys, float zeroValue, bool loop, [In] ref Vector2 bounds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureCurve>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zeroValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_Single_Boolean_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0004B968 File Offset: 0x00049B68
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 867019, RefRangeEnd = 867033, XrefRangeStart = 867019, XrefRangeEnd = 867033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextureCurve.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0004B9A4 File Offset: 0x00049BA4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0004B9D8 File Offset: 0x00049BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977720, XrefRangeEnd = 977725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x0004BA0C File Offset: 0x00049C0C
		[CallerCount(0)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr_SetDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0004BA40 File Offset: 0x00049C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977725, XrefRangeEnd = 977727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GraphicsFormat GetTextureFormat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr_GetTextureFormat_Private_Static_GraphicsFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0004BA70 File Offset: 0x00049C70
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 977752, RefRangeEnd = 977761, XrefRangeStart = 977727, XrefRangeEnd = 977752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr_GetTexture_Public_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0004BAB0 File Offset: 0x00049CB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 977781, RefRangeEnd = 977782, XrefRangeStart = 977761, XrefRangeEnd = 977781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Evaluate(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr_Evaluate_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0004BAFC File Offset: 0x00049CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977782, XrefRangeEnd = 977783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AddKey(float time, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0004BB54 File Offset: 0x00049D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977783, XrefRangeEnd = 977784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MoveKey(int index, [In] ref Keyframe key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_byref_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0004BBAC File Offset: 0x00049DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977784, XrefRangeEnd = 977785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0004BBEC File Offset: 0x00049DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977785, XrefRangeEnd = 977786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SmoothTangents(int index, float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurve.NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00008A35 File Offset: 0x00006C35
		public TextureCurve(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x0004BC38 File Offset: 0x00049E38
		// (set) Token: 0x06001064 RID: 4196 RVA: 0x00008A3E File Offset: 0x00006C3E
		public unsafe static int k_Precision
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextureCurve.NativeFieldInfoPtr_k_Precision, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureCurve.NativeFieldInfoPtr_k_Precision, (void*)(&value));
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001065 RID: 4197 RVA: 0x0004BC54 File Offset: 0x00049E54
		// (set) Token: 0x06001066 RID: 4198 RVA: 0x00008A4C File Offset: 0x00006C4C
		public unsafe static float k_Step
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TextureCurve.NativeFieldInfoPtr_k_Step, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureCurve.NativeFieldInfoPtr_k_Step, (void*)(&value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x0004BC70 File Offset: 0x00049E70
		// (set) Token: 0x06001068 RID: 4200 RVA: 0x00008A5A File Offset: 0x00006C5A
		public unsafe int _length_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr__length_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr__length_k__BackingField)) = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x0004BC98 File Offset: 0x00049E98
		// (set) Token: 0x0600106A RID: 4202 RVA: 0x00008A75 File Offset: 0x00006C75
		public unsafe bool m_Loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_Loop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_Loop)) = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x0004BCC0 File Offset: 0x00049EC0
		// (set) Token: 0x0600106C RID: 4204 RVA: 0x00008A90 File Offset: 0x00006C90
		public unsafe float m_ZeroValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_ZeroValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_ZeroValue)) = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x0004BCE8 File Offset: 0x00049EE8
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x00008AAB File Offset: 0x00006CAB
		public unsafe float m_Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_Range)) = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x0004BD10 File Offset: 0x00049F10
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x00008AC6 File Offset: 0x00006CC6
		public unsafe AnimationCurve m_Curve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_Curve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_Curve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x0004BD40 File Offset: 0x00049F40
		// (set) Token: 0x06001072 RID: 4210 RVA: 0x00008AE5 File Offset: 0x00006CE5
		public unsafe AnimationCurve m_LoopingCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_LoopingCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_LoopingCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0004BD70 File Offset: 0x00049F70
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x00008B04 File Offset: 0x00006D04
		public unsafe Texture2D m_Texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_Texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0004BDA0 File Offset: 0x00049FA0
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x00008B23 File Offset: 0x00006D23
		public unsafe bool m_IsCurveDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_IsCurveDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_IsCurveDirty)) = value;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x0004BDC8 File Offset: 0x00049FC8
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x00008B3E File Offset: 0x00006D3E
		public unsafe bool m_IsTextureDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_IsTextureDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureCurve.NativeFieldInfoPtr_m_IsTextureDirty)) = value;
			}
		}

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeFieldInfoPtr_k_Precision;

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeFieldInfoPtr_k_Step;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeFieldInfoPtr__length_k__BackingField;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeFieldInfoPtr_m_Loop;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeFieldInfoPtr_m_ZeroValue;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeFieldInfoPtr_m_Range;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeFieldInfoPtr_m_Curve;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeFieldInfoPtr_m_LoopingCurve;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeFieldInfoPtr_m_Texture;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeFieldInfoPtr_m_IsCurveDirty;

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeFieldInfoPtr_m_IsTextureDirty;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr_get_length_Public_get_Int32_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_set_length_Private_set_Void_Int32_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationCurve_Single_Boolean_byref_Vector2_0;

		// Token: 0x04000C80 RID: 3200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_Single_Boolean_byref_Vector2_0;

		// Token: 0x04000C81 RID: 3201
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000C82 RID: 3202
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Public_Void_0;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureFormat_Private_Static_GraphicsFormat_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture2D_0;

		// Token: 0x04000C87 RID: 3207
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_0;

		// Token: 0x04000C88 RID: 3208
		private static readonly IntPtr NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0;

		// Token: 0x04000C89 RID: 3209
		private static readonly IntPtr NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_byref_Keyframe_0;

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0;
	}
}
