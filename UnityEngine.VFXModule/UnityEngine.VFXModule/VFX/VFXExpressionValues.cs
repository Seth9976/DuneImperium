using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX
{
	// Token: 0x02000003 RID: 3
	public class VFXExpressionValues : Object
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00003994 File Offset: 0x00001B94
		// Note: this type is marked as 'beforefieldinit'.
		static VFXExpressionValues()
		{
			Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXExpressionValues");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr);
			VFXExpressionValues.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, "m_Ptr");
			VFXExpressionValues.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663307);
			VFXExpressionValues.NativeMethodInfoPtr_CreateExpressionValuesWrapper_Internal_Static_VFXExpressionValues_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr, 100663308);
			VFXExpressionValues.GetBoolDelegateField = IL2CPP.ResolveICall<VFXExpressionValues.GetBoolDelegate>("UnityEngine.VFX.VFXExpressionValues::GetBool");
			VFXExpressionValues.GetIntDelegateField = IL2CPP.ResolveICall<VFXExpressionValues.GetIntDelegate>("UnityEngine.VFX.VFXExpressionValues::GetInt");
			VFXExpressionValues.GetUIntDelegateField = IL2CPP.ResolveICall<VFXExpressionValues.GetUIntDelegate>("UnityEngine.VFX.VFXExpressionValues::GetUInt");
			VFXExpressionValues.GetFloatDelegateField = IL2CPP.ResolveICall<VFXExpressionValues.GetFloatDelegate>("UnityEngine.VFX.VFXExpressionValues::GetFloat");
			VFXExpressionValues.GetTextureDelegateField = IL2CPP.ResolveICall<VFXExpressionValues.GetTextureDelegate>("UnityEngine.VFX.VFXExpressionValues::GetTexture");
			VFXExpressionValues.GetMeshDelegateField = IL2CPP.ResolveICall<VFXExpressionValues.GetMeshDelegate>("UnityEngine.VFX.VFXExpressionValues::GetMesh");
			VFXExpressionValues.Internal_GetAnimationCurveFromScriptDelegateField = IL2CPP.ResolveICall<VFXExpressionValues.Internal_GetAnimationCurveFromScriptDelegate>("UnityEngine.VFX.VFXExpressionValues::Internal_GetAnimationCurveFromScript");
			VFXExpressionValues.Internal_GetGradientFromScriptDelegateField = IL2CPP.ResolveICall<VFXExpressionValues.Internal_GetGradientFromScriptDelegate>("UnityEngine.VFX.VFXExpressionValues::Internal_GetGradientFromScript");
			VFXExpressionValues.GetVector2_InjectedDelegateField = IL2CPP.ResolveICall<VFXExpressionValues.GetVector2_InjectedDelegate>("UnityEngine.VFX.VFXExpressionValues::GetVector2_Injected");
			VFXExpressionValues.GetVector3_InjectedDelegateField = IL2CPP.ResolveICall<VFXExpressionValues.GetVector3_InjectedDelegate>("UnityEngine.VFX.VFXExpressionValues::GetVector3_Injected");
			VFXExpressionValues.GetVector4_InjectedDelegateField = IL2CPP.ResolveICall<VFXExpressionValues.GetVector4_InjectedDelegate>("UnityEngine.VFX.VFXExpressionValues::GetVector4_Injected");
			VFXExpressionValues.GetMatrix4x4_InjectedDelegateField = IL2CPP.ResolveICall<VFXExpressionValues.GetMatrix4x4_InjectedDelegate>("UnityEngine.VFX.VFXExpressionValues::GetMatrix4x4_Injected");
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003AB4 File Offset: 0x00001CB4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXExpressionValues()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXExpressionValues>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXExpressionValues.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003AF0 File Offset: 0x00001CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269741, XrefRangeEnd = 1269745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXExpressionValues.NativeMethodInfoPtr_CreateExpressionValuesWrapper_Internal_Static_VFXExpressionValues_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VFXExpressionValues>(intPtr3) : null;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002366 File Offset: 0x00000566
		public VFXExpressionValues(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003B30 File Offset: 0x00001D30
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000236F File Offset: 0x0000056F
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXExpressionValues.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXExpressionValues.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000238A File Offset: 0x0000058A
		public bool GetBool(int nameID)
		{
			return VFXExpressionValues.GetBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000239D File Offset: 0x0000059D
		public int GetInt(int nameID)
		{
			return VFXExpressionValues.GetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000023B0 File Offset: 0x000005B0
		public uint GetUInt(int nameID)
		{
			return VFXExpressionValues.GetUIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000023C3 File Offset: 0x000005C3
		public float GetFloat(int nameID)
		{
			return VFXExpressionValues.GetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003B58 File Offset: 0x00001D58
		public Vector2 GetVector2(int nameID)
		{
			Vector2 vector;
			this.GetVector2_Injected(nameID, out vector);
			return vector;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003B70 File Offset: 0x00001D70
		public Vector3 GetVector3(int nameID)
		{
			Vector3 vector;
			this.GetVector3_Injected(nameID, out vector);
			return vector;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003B88 File Offset: 0x00001D88
		public Vector4 GetVector4(int nameID)
		{
			Vector4 vector;
			this.GetVector4_Injected(nameID, out vector);
			return vector;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003BA0 File Offset: 0x00001DA0
		public Matrix4x4 GetMatrix4x4(int nameID)
		{
			Matrix4x4 matrix4x;
			this.GetMatrix4x4_Injected(nameID, out matrix4x);
			return matrix4x;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003BB8 File Offset: 0x00001DB8
		public Texture GetTexture(int nameID)
		{
			IntPtr intPtr = VFXExpressionValues.GetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003BE8 File Offset: 0x00001DE8
		public Mesh GetMesh(int nameID)
		{
			IntPtr intPtr = VFXExpressionValues.GetMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003C18 File Offset: 0x00001E18
		public AnimationCurve GetAnimationCurve(int nameID)
		{
			AnimationCurve animationCurve = new AnimationCurve();
			this.Internal_GetAnimationCurveFromScript(nameID, animationCurve);
			return animationCurve;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000023D6 File Offset: 0x000005D6
		public void Internal_GetAnimationCurveFromScript(int nameID, AnimationCurve curve)
		{
			VFXExpressionValues.Internal_GetAnimationCurveFromScriptDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003C3C File Offset: 0x00001E3C
		public Gradient GetGradient(int nameID)
		{
			Gradient gradient = new Gradient();
			this.Internal_GetGradientFromScript(nameID, gradient);
			return gradient;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000023EF File Offset: 0x000005EF
		public void Internal_GetGradientFromScript(int nameID, Gradient gradient)
		{
			VFXExpressionValues.Internal_GetGradientFromScriptDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(gradient));
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003C60 File Offset: 0x00001E60
		public bool GetBool(string name)
		{
			return this.GetBool(Shader.PropertyToID(name));
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003C80 File Offset: 0x00001E80
		public int GetInt(string name)
		{
			return this.GetInt(Shader.PropertyToID(name));
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003CA0 File Offset: 0x00001EA0
		public uint GetUInt(string name)
		{
			return this.GetUInt(Shader.PropertyToID(name));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003CC0 File Offset: 0x00001EC0
		public float GetFloat(string name)
		{
			return this.GetFloat(Shader.PropertyToID(name));
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003CE0 File Offset: 0x00001EE0
		public Vector2 GetVector2(string name)
		{
			return this.GetVector2(Shader.PropertyToID(name));
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003D00 File Offset: 0x00001F00
		public Vector3 GetVector3(string name)
		{
			return this.GetVector3(Shader.PropertyToID(name));
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003D20 File Offset: 0x00001F20
		public Vector4 GetVector4(string name)
		{
			return this.GetVector4(Shader.PropertyToID(name));
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003D40 File Offset: 0x00001F40
		public Matrix4x4 GetMatrix4x4(string name)
		{
			return this.GetMatrix4x4(Shader.PropertyToID(name));
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003D60 File Offset: 0x00001F60
		public Texture GetTexture(string name)
		{
			return this.GetTexture(Shader.PropertyToID(name));
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003D80 File Offset: 0x00001F80
		public AnimationCurve GetAnimationCurve(string name)
		{
			return this.GetAnimationCurve(Shader.PropertyToID(name));
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003DA0 File Offset: 0x00001FA0
		public Gradient GetGradient(string name)
		{
			return this.GetGradient(Shader.PropertyToID(name));
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003DC0 File Offset: 0x00001FC0
		public Mesh GetMesh(string name)
		{
			return this.GetMesh(Shader.PropertyToID(name));
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002408 File Offset: 0x00000608
		public void GetVector2_Injected(int nameID, out Vector2 ret)
		{
			VFXExpressionValues.GetVector2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000241C File Offset: 0x0000061C
		public void GetVector3_Injected(int nameID, out Vector3 ret)
		{
			VFXExpressionValues.GetVector3_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002430 File Offset: 0x00000630
		public void GetVector4_Injected(int nameID, out Vector4 ret)
		{
			VFXExpressionValues.GetVector4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002444 File Offset: 0x00000644
		public void GetMatrix4x4_Injected(int nameID, out Matrix4x4 ret)
		{
			VFXExpressionValues.GetMatrix4x4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_CreateExpressionValuesWrapper_Internal_Static_VFXExpressionValues_IntPtr_0;

		// Token: 0x0400002B RID: 43
		private static readonly VFXExpressionValues.GetBoolDelegate GetBoolDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly VFXExpressionValues.GetIntDelegate GetIntDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly VFXExpressionValues.GetUIntDelegate GetUIntDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly VFXExpressionValues.GetFloatDelegate GetFloatDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly VFXExpressionValues.GetTextureDelegate GetTextureDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly VFXExpressionValues.GetMeshDelegate GetMeshDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly VFXExpressionValues.Internal_GetAnimationCurveFromScriptDelegate Internal_GetAnimationCurveFromScriptDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly VFXExpressionValues.Internal_GetGradientFromScriptDelegate Internal_GetGradientFromScriptDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly VFXExpressionValues.GetVector2_InjectedDelegate GetVector2_InjectedDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly VFXExpressionValues.GetVector3_InjectedDelegate GetVector3_InjectedDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly VFXExpressionValues.GetVector4_InjectedDelegate GetVector4_InjectedDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly VFXExpressionValues.GetMatrix4x4_InjectedDelegate GetMatrix4x4_InjectedDelegateField;

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x060001CB RID: 459
		private delegate bool GetBoolDelegate(IntPtr @this, int nameID);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x060001CD RID: 461
		private delegate int GetIntDelegate(IntPtr @this, int nameID);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x060001CF RID: 463
		private delegate uint GetUIntDelegate(IntPtr @this, int nameID);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x060001D1 RID: 465
		private delegate float GetFloatDelegate(IntPtr @this, int nameID);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x060001D3 RID: 467
		private delegate IntPtr GetTextureDelegate(IntPtr @this, int nameID);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x060001D5 RID: 469
		private delegate IntPtr GetMeshDelegate(IntPtr @this, int nameID);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x060001D7 RID: 471
		private delegate void Internal_GetAnimationCurveFromScriptDelegate(IntPtr @this, int nameID, IntPtr curve);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x060001D9 RID: 473
		private delegate void Internal_GetGradientFromScriptDelegate(IntPtr @this, int nameID, IntPtr gradient);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060001DB RID: 475
		private delegate void GetVector2_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060001DD RID: 477
		private delegate void GetVector3_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060001DF RID: 479
		private delegate void GetVector4_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060001E1 RID: 481
		private delegate void GetMatrix4x4_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);
	}
}
