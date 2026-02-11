using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000373 RID: 883
	public sealed class RayTracingShader : Object
	{
		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06002F6E RID: 12142 RVA: 0x000130FF File Offset: 0x000112FF
		public float maxRecursionDepth
		{
			get
			{
				return RayTracingShader.get_maxRecursionDepthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x00013111 File Offset: 0x00011311
		public void SetFloat(int nameID, float val)
		{
			RayTracingShader.SetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, val);
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x00013125 File Offset: 0x00011325
		public void SetInt(int nameID, int val)
		{
			RayTracingShader.SetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, val);
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x00013139 File Offset: 0x00011339
		public void SetVector(int nameID, Vector4 val)
		{
			this.SetVector_Injected(nameID, ref val);
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00013144 File Offset: 0x00011344
		public void SetMatrix(int nameID, Matrix4x4 val)
		{
			this.SetMatrix_Injected(nameID, ref val);
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x0001314F File Offset: 0x0001134F
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			RayTracingShader.SetFloatArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x00013168 File Offset: 0x00011368
		public void SetIntArray(int nameID, Il2CppStructArray<int> values)
		{
			RayTracingShader.SetIntArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002F75 RID: 12149 RVA: 0x00013181 File Offset: 0x00011381
		public void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			RayTracingShader.SetVectorArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002F76 RID: 12150 RVA: 0x0001319A File Offset: 0x0001139A
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			RayTracingShader.SetMatrixArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x000131B3 File Offset: 0x000113B3
		public void SetTexture(int nameID, Texture texture)
		{
			RayTracingShader.SetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x000131CC File Offset: 0x000113CC
		public void SetBuffer(int nameID, ComputeBuffer buffer)
		{
			RayTracingShader.SetBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x000131E5 File Offset: 0x000113E5
		public void SetGraphicsBuffer(int nameID, GraphicsBuffer buffer)
		{
			RayTracingShader.SetGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x000131FE File Offset: 0x000113FE
		public void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			RayTracingShader.SetConstantComputeBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x0001321A File Offset: 0x0001141A
		public void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			RayTracingShader.SetConstantGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x00013236 File Offset: 0x00011436
		public void SetAccelerationStructure(int nameID, RayTracingAccelerationStructure accelerationStructure)
		{
			RayTracingShader.SetAccelerationStructureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(accelerationStructure));
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x0001324F File Offset: 0x0001144F
		public void SetShaderPass(string passName)
		{
			RayTracingShader.SetShaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(passName));
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00013267 File Offset: 0x00011467
		public void SetTextureFromGlobal(int nameID, int globalTextureNameID)
		{
			RayTracingShader.SetTextureFromGlobalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, globalTextureNameID);
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x0001327B File Offset: 0x0001147B
		public void Dispatch(string rayGenFunctionName, int width, int height, int depth, [Optional] Camera camera)
		{
			RayTracingShader.DispatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(rayGenFunctionName), width, height, depth, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x0001329E File Offset: 0x0001149E
		public void SetBuffer(int nameID, GraphicsBuffer buffer)
		{
			this.SetGraphicsBuffer(nameID, buffer);
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x000132AA File Offset: 0x000114AA
		public void SetFloat(string name, float val)
		{
			this.SetFloat(Shader.PropertyToID(name), val);
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x000132BB File Offset: 0x000114BB
		public void SetInt(string name, int val)
		{
			this.SetInt(Shader.PropertyToID(name), val);
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x000132CC File Offset: 0x000114CC
		public void SetVector(string name, Vector4 val)
		{
			this.SetVector(Shader.PropertyToID(name), val);
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x000132DD File Offset: 0x000114DD
		public void SetMatrix(string name, Matrix4x4 val)
		{
			this.SetMatrix(Shader.PropertyToID(name), val);
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x000132EE File Offset: 0x000114EE
		public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x000132FF File Offset: 0x000114FF
		public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x00013310 File Offset: 0x00011510
		public void SetFloats(string name, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x00013321 File Offset: 0x00011521
		public void SetFloats(string name, params float[] values)
		{
			this.SetFloats(name, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x00013330 File Offset: 0x00011530
		public void SetFloats(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values);
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x0001333C File Offset: 0x0001153C
		public void SetFloats(int nameID, params float[] values)
		{
			this.SetFloats(nameID, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x0001334B File Offset: 0x0001154B
		public void SetInts(string name, Il2CppStructArray<int> values)
		{
			this.SetIntArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x0001335C File Offset: 0x0001155C
		public void SetInts(string name, params int[] values)
		{
			this.SetInts(name, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x0001336B File Offset: 0x0001156B
		public void SetInts(int nameID, Il2CppStructArray<int> values)
		{
			this.SetIntArray(nameID, values);
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x00013377 File Offset: 0x00011577
		public void SetInts(int nameID, params int[] values)
		{
			this.SetInts(nameID, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00013386 File Offset: 0x00011586
		public void SetBool(string name, bool val)
		{
			this.SetInt(Shader.PropertyToID(name), val ? 1 : 0);
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x0001339D File Offset: 0x0001159D
		public void SetBool(int nameID, bool val)
		{
			this.SetInt(nameID, val ? 1 : 0);
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x000133AF File Offset: 0x000115AF
		public void SetTexture(string name, Texture texture)
		{
			this.SetTexture(Shader.PropertyToID(name), texture);
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x000133C0 File Offset: 0x000115C0
		public void SetBuffer(string name, ComputeBuffer buffer)
		{
			this.SetBuffer(Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x000133D1 File Offset: 0x000115D1
		public void SetBuffer(string name, GraphicsBuffer buffer)
		{
			this.SetBuffer(Shader.PropertyToID(name), buffer);
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x000133E2 File Offset: 0x000115E2
		public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantComputeBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x000133F1 File Offset: 0x000115F1
		public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantComputeBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x00013405 File Offset: 0x00011605
		public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantGraphicsBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x00013414 File Offset: 0x00011614
		public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantGraphicsBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x00013428 File Offset: 0x00011628
		public void SetAccelerationStructure(string name, RayTracingAccelerationStructure accelerationStructure)
		{
			this.SetAccelerationStructure(Shader.PropertyToID(name), accelerationStructure);
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x00013439 File Offset: 0x00011639
		public void SetTextureFromGlobal(string name, string globalTextureName)
		{
			this.SetTextureFromGlobal(Shader.PropertyToID(name), Shader.PropertyToID(globalTextureName));
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x0001344F File Offset: 0x0001164F
		public void SetVector_Injected(int nameID, ref Vector4 val)
		{
			RayTracingShader.SetVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x00013463 File Offset: 0x00011663
		public void SetMatrix_Injected(int nameID, ref Matrix4x4 val)
		{
			RayTracingShader.SetMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x04002A9A RID: 10906
		private static readonly RayTracingShader.get_maxRecursionDepthDelegate get_maxRecursionDepthDelegateField = IL2CPP.ResolveICall<RayTracingShader.get_maxRecursionDepthDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::get_maxRecursionDepth");

		// Token: 0x04002A9B RID: 10907
		private static readonly RayTracingShader.SetFloatDelegate SetFloatDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetFloatDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetFloat");

		// Token: 0x04002A9C RID: 10908
		private static readonly RayTracingShader.SetIntDelegate SetIntDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetIntDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetInt");

		// Token: 0x04002A9D RID: 10909
		private static readonly RayTracingShader.SetFloatArrayDelegate SetFloatArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetFloatArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetFloatArray");

		// Token: 0x04002A9E RID: 10910
		private static readonly RayTracingShader.SetIntArrayDelegate SetIntArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetIntArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetIntArray");

		// Token: 0x04002A9F RID: 10911
		private static readonly RayTracingShader.SetVectorArrayDelegate SetVectorArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetVectorArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetVectorArray");

		// Token: 0x04002AA0 RID: 10912
		private static readonly RayTracingShader.SetMatrixArrayDelegate SetMatrixArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetMatrixArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetMatrixArray");

		// Token: 0x04002AA1 RID: 10913
		private static readonly RayTracingShader.SetTextureDelegate SetTextureDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetTextureDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetTexture");

		// Token: 0x04002AA2 RID: 10914
		private static readonly RayTracingShader.SetBufferDelegate SetBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetBuffer");

		// Token: 0x04002AA3 RID: 10915
		private static readonly RayTracingShader.SetGraphicsBufferDelegate SetGraphicsBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetGraphicsBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetGraphicsBuffer");

		// Token: 0x04002AA4 RID: 10916
		private static readonly RayTracingShader.SetConstantComputeBufferDelegate SetConstantComputeBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetConstantComputeBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetConstantComputeBuffer");

		// Token: 0x04002AA5 RID: 10917
		private static readonly RayTracingShader.SetConstantGraphicsBufferDelegate SetConstantGraphicsBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetConstantGraphicsBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetConstantGraphicsBuffer");

		// Token: 0x04002AA6 RID: 10918
		private static readonly RayTracingShader.SetAccelerationStructureDelegate SetAccelerationStructureDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetAccelerationStructureDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetAccelerationStructure");

		// Token: 0x04002AA7 RID: 10919
		private static readonly RayTracingShader.SetShaderPassDelegate SetShaderPassDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetShaderPassDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetShaderPass");

		// Token: 0x04002AA8 RID: 10920
		private static readonly RayTracingShader.SetTextureFromGlobalDelegate SetTextureFromGlobalDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetTextureFromGlobalDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetTextureFromGlobal");

		// Token: 0x04002AA9 RID: 10921
		private static readonly RayTracingShader.DispatchDelegate DispatchDelegateField = IL2CPP.ResolveICall<RayTracingShader.DispatchDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::Dispatch");

		// Token: 0x04002AAA RID: 10922
		private static readonly RayTracingShader.SetVector_InjectedDelegate SetVector_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetVector_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetVector_Injected");

		// Token: 0x04002AAB RID: 10923
		private static readonly RayTracingShader.SetMatrix_InjectedDelegate SetMatrix_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetMatrix_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetMatrix_Injected");

		// Token: 0x02000BC5 RID: 3013
		// (Invoke) Token: 0x06004077 RID: 16503
		private delegate float get_maxRecursionDepthDelegate(IntPtr @this);

		// Token: 0x02000BC6 RID: 3014
		// (Invoke) Token: 0x06004079 RID: 16505
		private delegate void SetFloatDelegate(IntPtr @this, int nameID, float val);

		// Token: 0x02000BC7 RID: 3015
		// (Invoke) Token: 0x0600407B RID: 16507
		private delegate void SetIntDelegate(IntPtr @this, int nameID, int val);

		// Token: 0x02000BC8 RID: 3016
		// (Invoke) Token: 0x0600407D RID: 16509
		private delegate void SetFloatArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000BC9 RID: 3017
		// (Invoke) Token: 0x0600407F RID: 16511
		private delegate void SetIntArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000BCA RID: 3018
		// (Invoke) Token: 0x06004081 RID: 16513
		private delegate void SetVectorArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000BCB RID: 3019
		// (Invoke) Token: 0x06004083 RID: 16515
		private delegate void SetMatrixArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000BCC RID: 3020
		// (Invoke) Token: 0x06004085 RID: 16517
		private delegate void SetTextureDelegate(IntPtr @this, int nameID, IntPtr texture);

		// Token: 0x02000BCD RID: 3021
		// (Invoke) Token: 0x06004087 RID: 16519
		private delegate void SetBufferDelegate(IntPtr @this, int nameID, IntPtr buffer);

		// Token: 0x02000BCE RID: 3022
		// (Invoke) Token: 0x06004089 RID: 16521
		private delegate void SetGraphicsBufferDelegate(IntPtr @this, int nameID, IntPtr buffer);

		// Token: 0x02000BCF RID: 3023
		// (Invoke) Token: 0x0600408B RID: 16523
		private delegate void SetConstantComputeBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000BD0 RID: 3024
		// (Invoke) Token: 0x0600408D RID: 16525
		private delegate void SetConstantGraphicsBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000BD1 RID: 3025
		// (Invoke) Token: 0x0600408F RID: 16527
		private delegate void SetAccelerationStructureDelegate(IntPtr @this, int nameID, IntPtr accelerationStructure);

		// Token: 0x02000BD2 RID: 3026
		// (Invoke) Token: 0x06004091 RID: 16529
		private delegate void SetShaderPassDelegate(IntPtr @this, IntPtr passName);

		// Token: 0x02000BD3 RID: 3027
		// (Invoke) Token: 0x06004093 RID: 16531
		private delegate void SetTextureFromGlobalDelegate(IntPtr @this, int nameID, int globalTextureNameID);

		// Token: 0x02000BD4 RID: 3028
		// (Invoke) Token: 0x06004095 RID: 16533
		private delegate void DispatchDelegate(IntPtr @this, IntPtr rayGenFunctionName, int width, int height, int depth, IntPtr camera);

		// Token: 0x02000BD5 RID: 3029
		// (Invoke) Token: 0x06004097 RID: 16535
		private delegate void SetVector_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);

		// Token: 0x02000BD6 RID: 3030
		// (Invoke) Token: 0x06004099 RID: 16537
		private delegate void SetMatrix_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);
	}
}
