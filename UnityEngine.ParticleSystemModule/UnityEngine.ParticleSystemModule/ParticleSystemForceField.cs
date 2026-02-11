using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000032 RID: 50
	public class ParticleSystemForceField : Behaviour
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000211F File Offset: 0x0000031F
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002131 File Offset: 0x00000331
		public ParticleSystemForceFieldShape shape
		{
			get
			{
				return ParticleSystemForceField.get_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_shapeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00002144 File Offset: 0x00000344
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002156 File Offset: 0x00000356
		public float startRange
		{
			get
			{
				return ParticleSystemForceField.get_startRangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_startRangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00002169 File Offset: 0x00000369
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000217B File Offset: 0x0000037B
		public float endRange
		{
			get
			{
				return ParticleSystemForceField.get_endRangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_endRangeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000218E File Offset: 0x0000038E
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000021A0 File Offset: 0x000003A0
		public float length
		{
			get
			{
				return ParticleSystemForceField.get_lengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_lengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000101 RID: 257 RVA: 0x000021B3 File Offset: 0x000003B3
		// (set) Token: 0x06000102 RID: 258 RVA: 0x000021C5 File Offset: 0x000003C5
		public float gravityFocus
		{
			get
			{
				return ParticleSystemForceField.get_gravityFocusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_gravityFocusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000084C0 File Offset: 0x000066C0
		// (set) Token: 0x06000104 RID: 260 RVA: 0x000021D8 File Offset: 0x000003D8
		public Vector2 rotationRandomness
		{
			get
			{
				Vector2 vector;
				this.get_rotationRandomness_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_rotationRandomness_Injected(ref value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000021E2 File Offset: 0x000003E2
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000021F4 File Offset: 0x000003F4
		public bool multiplyDragByParticleSize
		{
			get
			{
				return ParticleSystemForceField.get_multiplyDragByParticleSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_multiplyDragByParticleSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00002207 File Offset: 0x00000407
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00002219 File Offset: 0x00000419
		public bool multiplyDragByParticleVelocity
		{
			get
			{
				return ParticleSystemForceField.get_multiplyDragByParticleVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ParticleSystemForceField.set_multiplyDragByParticleVelocityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000084D8 File Offset: 0x000066D8
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000222C File Offset: 0x0000042C
		public Texture3D vectorField
		{
			get
			{
				IntPtr intPtr = ParticleSystemForceField.get_vectorFieldDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture3D>(intPtr2) : null;
			}
			set
			{
				ParticleSystemForceField.set_vectorFieldDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00008504 File Offset: 0x00006704
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002244 File Offset: 0x00000444
		public ParticleSystem.MinMaxCurve directionX
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_directionX_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_directionX_Injected(ref value);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000851C File Offset: 0x0000671C
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000224E File Offset: 0x0000044E
		public ParticleSystem.MinMaxCurve directionY
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_directionY_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_directionY_Injected(ref value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00008534 File Offset: 0x00006734
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00002258 File Offset: 0x00000458
		public ParticleSystem.MinMaxCurve directionZ
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_directionZ_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_directionZ_Injected(ref value);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000854C File Offset: 0x0000674C
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002262 File Offset: 0x00000462
		public ParticleSystem.MinMaxCurve gravity
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_gravity_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_gravity_Injected(ref value);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00008564 File Offset: 0x00006764
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000226C File Offset: 0x0000046C
		public ParticleSystem.MinMaxCurve rotationSpeed
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_rotationSpeed_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_rotationSpeed_Injected(ref value);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000857C File Offset: 0x0000677C
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00002276 File Offset: 0x00000476
		public ParticleSystem.MinMaxCurve rotationAttraction
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_rotationAttraction_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_rotationAttraction_Injected(ref value);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00008594 File Offset: 0x00006794
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00002280 File Offset: 0x00000480
		public ParticleSystem.MinMaxCurve drag
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_drag_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_drag_Injected(ref value);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000085AC File Offset: 0x000067AC
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000228A File Offset: 0x0000048A
		public ParticleSystem.MinMaxCurve vectorFieldSpeed
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_vectorFieldSpeed_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_vectorFieldSpeed_Injected(ref value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600011B RID: 283 RVA: 0x000085C4 File Offset: 0x000067C4
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00002294 File Offset: 0x00000494
		public ParticleSystem.MinMaxCurve vectorFieldAttraction
		{
			get
			{
				ParticleSystem.MinMaxCurve minMaxCurve;
				this.get_vectorFieldAttraction_Injected(out minMaxCurve);
				return minMaxCurve;
			}
			set
			{
				this.set_vectorFieldAttraction_Injected(ref value);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000229E File Offset: 0x0000049E
		public void get_rotationRandomness_Injected(out Vector2 ret)
		{
			ParticleSystemForceField.get_rotationRandomness_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000022B1 File Offset: 0x000004B1
		public void set_rotationRandomness_Injected(ref Vector2 value)
		{
			ParticleSystemForceField.set_rotationRandomness_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000085DC File Offset: 0x000067DC
		public unsafe void get_directionX_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_directionX_InjectedDelegate get_directionX_InjectedDelegate = ParticleSystemForceField.get_directionX_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_directionX_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00008604 File Offset: 0x00006804
		public unsafe void set_directionX_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_directionX_InjectedDelegate set_directionX_InjectedDelegate = ParticleSystemForceField.set_directionX_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_directionX_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000862C File Offset: 0x0000682C
		public unsafe void get_directionY_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_directionY_InjectedDelegate get_directionY_InjectedDelegate = ParticleSystemForceField.get_directionY_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_directionY_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00008654 File Offset: 0x00006854
		public unsafe void set_directionY_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_directionY_InjectedDelegate set_directionY_InjectedDelegate = ParticleSystemForceField.set_directionY_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_directionY_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000867C File Offset: 0x0000687C
		public unsafe void get_directionZ_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_directionZ_InjectedDelegate get_directionZ_InjectedDelegate = ParticleSystemForceField.get_directionZ_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_directionZ_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000086A4 File Offset: 0x000068A4
		public unsafe void set_directionZ_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_directionZ_InjectedDelegate set_directionZ_InjectedDelegate = ParticleSystemForceField.set_directionZ_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_directionZ_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000086CC File Offset: 0x000068CC
		public unsafe void get_gravity_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_gravity_InjectedDelegate get_gravity_InjectedDelegate = ParticleSystemForceField.get_gravity_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_gravity_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000086F4 File Offset: 0x000068F4
		public unsafe void set_gravity_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_gravity_InjectedDelegate set_gravity_InjectedDelegate = ParticleSystemForceField.set_gravity_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_gravity_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000871C File Offset: 0x0000691C
		public unsafe void get_rotationSpeed_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_rotationSpeed_InjectedDelegate get_rotationSpeed_InjectedDelegate = ParticleSystemForceField.get_rotationSpeed_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_rotationSpeed_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00008744 File Offset: 0x00006944
		public unsafe void set_rotationSpeed_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_rotationSpeed_InjectedDelegate set_rotationSpeed_InjectedDelegate = ParticleSystemForceField.set_rotationSpeed_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_rotationSpeed_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000876C File Offset: 0x0000696C
		public unsafe void get_rotationAttraction_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_rotationAttraction_InjectedDelegate get_rotationAttraction_InjectedDelegate = ParticleSystemForceField.get_rotationAttraction_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_rotationAttraction_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00008794 File Offset: 0x00006994
		public unsafe void set_rotationAttraction_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_rotationAttraction_InjectedDelegate set_rotationAttraction_InjectedDelegate = ParticleSystemForceField.set_rotationAttraction_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_rotationAttraction_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000087BC File Offset: 0x000069BC
		public unsafe void get_drag_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_drag_InjectedDelegate get_drag_InjectedDelegate = ParticleSystemForceField.get_drag_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_drag_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000087E4 File Offset: 0x000069E4
		public unsafe void set_drag_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_drag_InjectedDelegate set_drag_InjectedDelegate = ParticleSystemForceField.set_drag_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_drag_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000880C File Offset: 0x00006A0C
		public unsafe void get_vectorFieldSpeed_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_vectorFieldSpeed_InjectedDelegate get_vectorFieldSpeed_InjectedDelegate = ParticleSystemForceField.get_vectorFieldSpeed_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_vectorFieldSpeed_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00008834 File Offset: 0x00006A34
		public unsafe void set_vectorFieldSpeed_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_vectorFieldSpeed_InjectedDelegate set_vectorFieldSpeed_InjectedDelegate = ParticleSystemForceField.set_vectorFieldSpeed_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_vectorFieldSpeed_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000885C File Offset: 0x00006A5C
		public unsafe void get_vectorFieldAttraction_Injected(out ParticleSystem.MinMaxCurve ret)
		{
			ParticleSystemForceField.get_vectorFieldAttraction_InjectedDelegate get_vectorFieldAttraction_InjectedDelegate = ParticleSystemForceField.get_vectorFieldAttraction_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(ret);
			get_vectorFieldAttraction_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00008884 File Offset: 0x00006A84
		public unsafe void set_vectorFieldAttraction_Injected(ref ParticleSystem.MinMaxCurve value)
		{
			ParticleSystemForceField.set_vectorFieldAttraction_InjectedDelegate set_vectorFieldAttraction_InjectedDelegate = ParticleSystemForceField.set_vectorFieldAttraction_InjectedDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			set_vectorFieldAttraction_InjectedDelegate(intPtr, &intPtr2);
		}

		// Token: 0x04000217 RID: 535
		private static readonly ParticleSystemForceField.get_shapeDelegate get_shapeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_shapeDelegate>("UnityEngine.ParticleSystemForceField::get_shape");

		// Token: 0x04000218 RID: 536
		private static readonly ParticleSystemForceField.set_shapeDelegate set_shapeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_shapeDelegate>("UnityEngine.ParticleSystemForceField::set_shape");

		// Token: 0x04000219 RID: 537
		private static readonly ParticleSystemForceField.get_startRangeDelegate get_startRangeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_startRangeDelegate>("UnityEngine.ParticleSystemForceField::get_startRange");

		// Token: 0x0400021A RID: 538
		private static readonly ParticleSystemForceField.set_startRangeDelegate set_startRangeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_startRangeDelegate>("UnityEngine.ParticleSystemForceField::set_startRange");

		// Token: 0x0400021B RID: 539
		private static readonly ParticleSystemForceField.get_endRangeDelegate get_endRangeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_endRangeDelegate>("UnityEngine.ParticleSystemForceField::get_endRange");

		// Token: 0x0400021C RID: 540
		private static readonly ParticleSystemForceField.set_endRangeDelegate set_endRangeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_endRangeDelegate>("UnityEngine.ParticleSystemForceField::set_endRange");

		// Token: 0x0400021D RID: 541
		private static readonly ParticleSystemForceField.get_lengthDelegate get_lengthDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_lengthDelegate>("UnityEngine.ParticleSystemForceField::get_length");

		// Token: 0x0400021E RID: 542
		private static readonly ParticleSystemForceField.set_lengthDelegate set_lengthDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_lengthDelegate>("UnityEngine.ParticleSystemForceField::set_length");

		// Token: 0x0400021F RID: 543
		private static readonly ParticleSystemForceField.get_gravityFocusDelegate get_gravityFocusDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_gravityFocusDelegate>("UnityEngine.ParticleSystemForceField::get_gravityFocus");

		// Token: 0x04000220 RID: 544
		private static readonly ParticleSystemForceField.set_gravityFocusDelegate set_gravityFocusDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_gravityFocusDelegate>("UnityEngine.ParticleSystemForceField::set_gravityFocus");

		// Token: 0x04000221 RID: 545
		private static readonly ParticleSystemForceField.get_multiplyDragByParticleSizeDelegate get_multiplyDragByParticleSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_multiplyDragByParticleSizeDelegate>("UnityEngine.ParticleSystemForceField::get_multiplyDragByParticleSize");

		// Token: 0x04000222 RID: 546
		private static readonly ParticleSystemForceField.set_multiplyDragByParticleSizeDelegate set_multiplyDragByParticleSizeDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_multiplyDragByParticleSizeDelegate>("UnityEngine.ParticleSystemForceField::set_multiplyDragByParticleSize");

		// Token: 0x04000223 RID: 547
		private static readonly ParticleSystemForceField.get_multiplyDragByParticleVelocityDelegate get_multiplyDragByParticleVelocityDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_multiplyDragByParticleVelocityDelegate>("UnityEngine.ParticleSystemForceField::get_multiplyDragByParticleVelocity");

		// Token: 0x04000224 RID: 548
		private static readonly ParticleSystemForceField.set_multiplyDragByParticleVelocityDelegate set_multiplyDragByParticleVelocityDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_multiplyDragByParticleVelocityDelegate>("UnityEngine.ParticleSystemForceField::set_multiplyDragByParticleVelocity");

		// Token: 0x04000225 RID: 549
		private static readonly ParticleSystemForceField.get_vectorFieldDelegate get_vectorFieldDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_vectorFieldDelegate>("UnityEngine.ParticleSystemForceField::get_vectorField");

		// Token: 0x04000226 RID: 550
		private static readonly ParticleSystemForceField.set_vectorFieldDelegate set_vectorFieldDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_vectorFieldDelegate>("UnityEngine.ParticleSystemForceField::set_vectorField");

		// Token: 0x04000227 RID: 551
		private static readonly ParticleSystemForceField.get_rotationRandomness_InjectedDelegate get_rotationRandomness_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_rotationRandomness_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_rotationRandomness_Injected");

		// Token: 0x04000228 RID: 552
		private static readonly ParticleSystemForceField.set_rotationRandomness_InjectedDelegate set_rotationRandomness_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_rotationRandomness_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_rotationRandomness_Injected");

		// Token: 0x04000229 RID: 553
		private static readonly ParticleSystemForceField.get_directionX_InjectedDelegate get_directionX_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_directionX_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_directionX_Injected");

		// Token: 0x0400022A RID: 554
		private static readonly ParticleSystemForceField.set_directionX_InjectedDelegate set_directionX_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_directionX_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_directionX_Injected");

		// Token: 0x0400022B RID: 555
		private static readonly ParticleSystemForceField.get_directionY_InjectedDelegate get_directionY_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_directionY_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_directionY_Injected");

		// Token: 0x0400022C RID: 556
		private static readonly ParticleSystemForceField.set_directionY_InjectedDelegate set_directionY_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_directionY_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_directionY_Injected");

		// Token: 0x0400022D RID: 557
		private static readonly ParticleSystemForceField.get_directionZ_InjectedDelegate get_directionZ_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_directionZ_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_directionZ_Injected");

		// Token: 0x0400022E RID: 558
		private static readonly ParticleSystemForceField.set_directionZ_InjectedDelegate set_directionZ_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_directionZ_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_directionZ_Injected");

		// Token: 0x0400022F RID: 559
		private static readonly ParticleSystemForceField.get_gravity_InjectedDelegate get_gravity_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_gravity_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_gravity_Injected");

		// Token: 0x04000230 RID: 560
		private static readonly ParticleSystemForceField.set_gravity_InjectedDelegate set_gravity_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_gravity_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_gravity_Injected");

		// Token: 0x04000231 RID: 561
		private static readonly ParticleSystemForceField.get_rotationSpeed_InjectedDelegate get_rotationSpeed_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_rotationSpeed_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_rotationSpeed_Injected");

		// Token: 0x04000232 RID: 562
		private static readonly ParticleSystemForceField.set_rotationSpeed_InjectedDelegate set_rotationSpeed_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_rotationSpeed_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_rotationSpeed_Injected");

		// Token: 0x04000233 RID: 563
		private static readonly ParticleSystemForceField.get_rotationAttraction_InjectedDelegate get_rotationAttraction_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_rotationAttraction_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_rotationAttraction_Injected");

		// Token: 0x04000234 RID: 564
		private static readonly ParticleSystemForceField.set_rotationAttraction_InjectedDelegate set_rotationAttraction_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_rotationAttraction_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_rotationAttraction_Injected");

		// Token: 0x04000235 RID: 565
		private static readonly ParticleSystemForceField.get_drag_InjectedDelegate get_drag_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_drag_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_drag_Injected");

		// Token: 0x04000236 RID: 566
		private static readonly ParticleSystemForceField.set_drag_InjectedDelegate set_drag_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_drag_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_drag_Injected");

		// Token: 0x04000237 RID: 567
		private static readonly ParticleSystemForceField.get_vectorFieldSpeed_InjectedDelegate get_vectorFieldSpeed_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_vectorFieldSpeed_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_vectorFieldSpeed_Injected");

		// Token: 0x04000238 RID: 568
		private static readonly ParticleSystemForceField.set_vectorFieldSpeed_InjectedDelegate set_vectorFieldSpeed_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_vectorFieldSpeed_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_vectorFieldSpeed_Injected");

		// Token: 0x04000239 RID: 569
		private static readonly ParticleSystemForceField.get_vectorFieldAttraction_InjectedDelegate get_vectorFieldAttraction_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.get_vectorFieldAttraction_InjectedDelegate>("UnityEngine.ParticleSystemForceField::get_vectorFieldAttraction_Injected");

		// Token: 0x0400023A RID: 570
		private static readonly ParticleSystemForceField.set_vectorFieldAttraction_InjectedDelegate set_vectorFieldAttraction_InjectedDelegateField = IL2CPP.ResolveICall<ParticleSystemForceField.set_vectorFieldAttraction_InjectedDelegate>("UnityEngine.ParticleSystemForceField::set_vectorFieldAttraction_Injected");

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600026C RID: 620
		private delegate ParticleSystemForceFieldShape get_shapeDelegate(IntPtr @this);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x0600026E RID: 622
		private delegate void set_shapeDelegate(IntPtr @this, ParticleSystemForceFieldShape value);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000270 RID: 624
		private delegate float get_startRangeDelegate(IntPtr @this);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06000272 RID: 626
		private delegate void set_startRangeDelegate(IntPtr @this, float value);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000274 RID: 628
		private delegate float get_endRangeDelegate(IntPtr @this);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x06000276 RID: 630
		private delegate void set_endRangeDelegate(IntPtr @this, float value);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x06000278 RID: 632
		private delegate float get_lengthDelegate(IntPtr @this);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x0600027A RID: 634
		private delegate void set_lengthDelegate(IntPtr @this, float value);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x0600027C RID: 636
		private delegate float get_gravityFocusDelegate(IntPtr @this);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x0600027E RID: 638
		private delegate void set_gravityFocusDelegate(IntPtr @this, float value);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x06000280 RID: 640
		private delegate bool get_multiplyDragByParticleSizeDelegate(IntPtr @this);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x06000282 RID: 642
		private delegate void set_multiplyDragByParticleSizeDelegate(IntPtr @this, bool value);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x06000284 RID: 644
		private delegate bool get_multiplyDragByParticleVelocityDelegate(IntPtr @this);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x06000286 RID: 646
		private delegate void set_multiplyDragByParticleVelocityDelegate(IntPtr @this, bool value);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x06000288 RID: 648
		private delegate IntPtr get_vectorFieldDelegate(IntPtr @this);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x0600028A RID: 650
		private delegate void set_vectorFieldDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x0600028C RID: 652
		private delegate void get_rotationRandomness_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x0600028E RID: 654
		private delegate void set_rotationRandomness_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000290 RID: 656
		private delegate void get_directionX_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x06000292 RID: 658
		private delegate void set_directionX_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x06000294 RID: 660
		private delegate void get_directionY_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x06000296 RID: 662
		private delegate void set_directionY_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x06000298 RID: 664
		private delegate void get_directionZ_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x0600029A RID: 666
		private delegate void set_directionZ_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x0600029C RID: 668
		private delegate void get_gravity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x0600029E RID: 670
		private delegate void set_gravity_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x060002A0 RID: 672
		private delegate void get_rotationSpeed_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x060002A2 RID: 674
		private delegate void set_rotationSpeed_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x060002A4 RID: 676
		private delegate void get_rotationAttraction_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x060002A6 RID: 678
		private delegate void set_rotationAttraction_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x060002A8 RID: 680
		private delegate void get_drag_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x060002AA RID: 682
		private delegate void set_drag_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x060002AC RID: 684
		private delegate void get_vectorFieldSpeed_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x060002AE RID: 686
		private delegate void set_vectorFieldSpeed_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x060002B0 RID: 688
		private delegate void get_vectorFieldAttraction_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x060002B2 RID: 690
		private delegate void set_vectorFieldAttraction_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
